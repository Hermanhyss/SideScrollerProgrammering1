using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MyMovingBlock : MonoBehaviour
{ 
public float amplitude = 1f; // Adjust this value to control the movement range
public float speed = 2f; // Adjust this value to control the movement speed

private float initialY;

void Start()
{
    // Save the initial y position of the block
    initialY = transform.position.y;
}

void Update()
{
    // Calculate the vertical movement using Mathf.Sin to create an oscillating motion
    float verticalMovement = Mathf.Sin(Time.time * speed) * amplitude;

    // Update the y position of the block
    transform.position = new Vector3(transform.position.x, initialY + verticalMovement, transform.position.z);
}
}
  
