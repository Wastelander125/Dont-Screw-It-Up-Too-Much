using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class IntroMusic : MonoBehaviour

{

 void Awake()
{
 string currentSceneName = SceneManager.GetActiveScene().name;


    if(currentSceneName == "Scene 1 (uvod)")
    {
        Destroy(gameObject);
    }
    else
    {
    DontDestroyOnLoad(gameObject);
    }
}

}