using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mob : MonoBehaviour
{
    public int HP = 0;
    public Rigidbody2D myRigidBody = null;

    public float MovmentSpeedPersecond = 10.0f;
    // Start is called before the first frame update
    public float MovementSign = 1.0f;

    void FixedUpdate()
    {
        Vector3 charcterVelocity = myRigidBody.velocity;

        charcterVelocity.x = 0;

        charcterVelocity += MovementSign * MovmentSpeedPersecond * transform.right.normalized;
        myRigidBody.velocity = charcterVelocity; 

        myRigidBody.velocity = charcterVelocity;
     }
    public void TakeDamage(int aDamageValue)
    {
        HP += aDamageValue;
        if(HP < 0) 
        { 
            GameObject.Destroy(this.gameObject); 
        }
    }
}
