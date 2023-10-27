using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenesloader : MonoBehaviour
{
    public void LoadScene(string aSceneNamn)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(aSceneNamn);
        
    
    }
} 
