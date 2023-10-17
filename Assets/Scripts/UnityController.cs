using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class UnityController : MonoBehaviour
{
    public Rigidbody2D Myrigidbody = null;

    public CharacterState JumpingState = CharacterState.Airborne; // är karaktären på marken eller i luften?



    public float MovementSpeedPerSecond = 10.0f; // gå
    public float GravityPerSecond = 140.0f; // falla
   

    //hoppa
    public float JumpSpeedFactor = 3.0f; // Hur mycket snabbare hoppet är
    public float JumpMaxHeight = 150;
    private float JumpHeightDelta = 0.0f;

    // Update is called once per frame
    void FixedUpdate()
      
    {
        Vector3 characterVelocity = Myrigidbody.velocity;
        characterVelocity.x = 0.0f;
        characterVelocity.y = 0.0f;

if (JumpingState != CharacterState.Jumping)
        {
            JumpingState = CharacterState.Grounded;
        }
         
       
            
            if (Input.GetKey(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {
            JumpingState = CharacterState.Jumping;
            JumpHeightDelta = 0.0f;
        }

        if (JumpingState == CharacterState.Jumping)
        {
            float totalJumpMovementThisFrame = MovementSpeedPerSecond * JumpSpeedFactor;
            characterVelocity.y += totalJumpMovementThisFrame;
           
            JumpHeightDelta += totalJumpMovementThisFrame;
            if (JumpHeightDelta >= JumpMaxHeight)
            {
                JumpingState = CharacterState.Airborne;
                JumpHeightDelta = 0.0f;
                characterVelocity.y = 0.0f;
            }
         }

        if (Input.GetKey(KeyCode.A)) // vänster
        {
            
            characterVelocity.x -= MovementSpeedPerSecond;
   
        }
        if (Input.GetKey(KeyCode.D)) // höger
        {
            
            characterVelocity.x += MovementSpeedPerSecond;  
        }
        Myrigidbody.velocity = characterVelocity;
        {
       
         
        }
    }
}

