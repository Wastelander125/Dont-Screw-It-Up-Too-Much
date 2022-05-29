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
        _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    
    void Update()
    {
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