using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mob : MonoBehaviour
{
    public Rigidbody2D myRigidBody = null;

    public float MovmentSpeedPersecond = 10;
    // Start is called before the first frame update
   
        void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 charcterVelocity = myRigidBody.velocity;

        charcterVelocity.x = 0;

        charcterVelocity += MovmentSpeedPersecond * transform.right.normalized;
        myRigidBody.velocity = charcterVelocity;
     }
}
