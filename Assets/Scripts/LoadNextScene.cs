using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

public void LoadNextSceneA() 
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }



public void LoadStartScene()

    {
        SceneManager.LoadScene(0);
    }

public void Quiter()

    {
        Application.Quit();
        Debug.Log ("goodby");
    }
public void Credits()

    {
        SceneManager.LoadScene(4);
    }

}
