using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class IntroMusic : MonoBehaviour
{
    private int _currentSceneIndex;
    private void Awake()
    {
        
    }
    
    void Update()
    {

        _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        if(_currentSceneIndex == 1)
        {
            Destroy(GetComponent<AudioSource>());
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

}