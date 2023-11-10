using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollison : MonoBehaviour
{
    public Mob myEnemyScript = null; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 EnemyScale =  myEnemyScript.transform.localScale;
        EnemyScale.x = -EnemyScale.x;
        myEnemyScript.transform.localScale = EnemyScale;
        myEnemyScript.MovementSign *= -1; 
    }
}

