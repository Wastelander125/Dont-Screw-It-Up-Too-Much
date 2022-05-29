using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class IntroMusic : MonoBehaviour
{
    private int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    void Update()
    {
        if(currentSceneIndex == 1)
        {
            Destroy(GetComponent<AudioSource>());
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

}