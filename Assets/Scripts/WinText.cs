using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winText;
    int winNumber;

    private void Awake() 
    {
        winNumber = Ghosts.right;
    }
    private void Start() 
    {
        winText.text = "You suprised me Bob " + winNumber + " out of 10 is not bad result. Maybe someday you will do this work instead of me hahaha...";
    }

    public void WinMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
