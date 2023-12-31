using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public enum Characterstate
{
 Ground = 0,
 Airbone = 1,
 Jumping = 2,
 Total
}
public class PhysicsCharacterController : MonoBehaviour
{
    public List<Sprite> CharacterSprite = new List<Sprite>();
    public int HP = 0;
    //Refrence to rigidbody on same object
    public Rigidbody2D myRigidBody = null;

    public CharacterState JumpingState = CharacterState.Airborne;
    //Is Our character on the ground or in the air?

    //Gravity
    public float GravityPerSecond = 160.0f; //Falling Speed
    public float GroundLevel = 0.0f; //Ground Value

    //Jump
    public float JumpSpeedFactor = 3.0f; //How much faster is the jump than the movespeed?
    public float JumpMaxHeight = 150.0f;
    [SerializeField]
    private float JumpHeightDelta = 0.0f;

    //Movement
    public float MovementSpeedPerSecond = 10.0f; //Movement Speed

    public SpriteRenderer mySpriteRender = null;
    private void Update()
    {
        if (HP <= 0)
        { 
        Scenesloader MySceneLoader = gameObject .GetComponent<Scenesloader>();
            if (MySceneLoader != null )
            {
                MySceneLoader.LoadScene("Game Over");
            }
        }

        int hpCopy = HP - 1;

        if (hpCopy < 0)
        {
            hpCopy = 0;
        }
        if (hpCopy >= CharacterSprite.Count)
        {
            hpCopy = CharacterSprite.Count - 1;
        }

        mySpriteRender.sprite = CharacterSprite[HP];




        if (Input.GetKeyDown(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {
            JumpingState = CharacterState.Jumping; //Set character to jumping
            JumpHeightDelta = 0.0f; //Restart Counting Jumpdistance

        }

    }


    void FixedUpdate()
    {
        Vector3 characterVelocity = myRigidBody.velocity;
        characterVelocity.x = 0.0f;

        if (JumpingState == CharacterState.Jumping)
        {
            float totalJumpMovementThisFrame = MovementSpeedPerSecond * JumpSpeedFactor;
            characterVelocity.y = totalJumpMovementThisFrame;

            JumpHeightDelta += totalJumpMovementThisFrame * Time.deltaTime;

            if (JumpHeightDelta >= JumpMaxHeight)
            {
                JumpingState = CharacterState.Airborne;
                JumpHeightDelta = 0.0f;
                characterVelocity.y = 0.0f;
            }
        }

        //Left
        if (Input.GetKey(KeyCode.A))
        {
            characterVelocity.x -= MovementSpeedPerSecond;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            characterVelocity.x += MovementSpeedPerSecond;
        }
        myRigidBody.velocity = characterVelocity;

    }
   
}