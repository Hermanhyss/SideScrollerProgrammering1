using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinGubbeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float MovementSpeedPerSecond = 10.0f;
    public float GravityPerSecond = 160.0f;
    public float Groundlevel = 0.0f;

    void Update()
    
    {
        //gravtity 
        Vector3 gravityPosition = transform.position;
        gravityPosition.y -= GravityPerSecond * Time.deltaTime;
        if(gravityPosition.y < Groundlevel) {gravityPosition.y = Groundlevel;}
        transform.position = gravityPosition;

        //Up
        if (Input.GetKey(KeyCode.W))
        {
           Vector3 characterPositoin = transform.position;
            characterPositoin.y += MovementSpeedPerSecond * Time.deltaTime; 
            transform.position = characterPositoin;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 characterPositoin = transform.position;
            characterPositoin.x += MovementSpeedPerSecond * Time.deltaTime;
            transform.position = characterPositoin;
        }
        //Left 
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 characterPositoin = transform.position;
            characterPositoin.x -= MovementSpeedPerSecond * Time.deltaTime;
            transform.position = characterPositoin;
        }
        //Down
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 characterPositoin = transform.position;
            characterPositoin.y -= MovementSpeedPerSecond * Time.deltaTime;
            transform.position = characterPositoin;
        }




    }




}
