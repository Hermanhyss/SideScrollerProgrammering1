using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Block : MonoBehaviour
{
    // x = Width , y = Height 
    public Vector2 Dimensions = new Vector2(16.0f, 16.0f);

    public Vector2 LowerleftCorner = new Vector2();
    public static bool CheckCollision(Block aObject1, Block aObject2)
    {
        if (aObject1.LowerleftCorner.x < aObject2.LowerleftCorner.x + aObject2.Dimensions.x &&

           aObject1.LowerleftCorner.x + aObject2.LowerleftCorner.x > aObject2.Dimensions.x &&

           aObject1.LowerleftCorner.y < aObject2.LowerleftCorner.y + aObject2.Dimensions.y &&

           aObject1.LowerleftCorner.y + aObject2.LowerleftCorner.y > aObject2.Dimensions.y)
            {
            return true;
        }

        return false;

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LowerleftCorner = new Vector2(transform.position.x - (Dimensions.x * 0.5f),
            transform.position.y - (Dimensions.y * 0.5f));

    }
}
