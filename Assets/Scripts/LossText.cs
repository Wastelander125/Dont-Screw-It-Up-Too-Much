using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LossText : MonoBehaviour
{
    public int numberOfMistakes;
    [SerializeField] TextMeshProUGUI lossTextField;


    private void Awake() 
    {
        numberOfMistakes = Ghosts.wrong;
    }
    private void Start() 
    {
       lossTextField.text = "Oh look what have you done. You have send down to hell " + numberOfMistakes + " out of 10 people by mistake. Go to hell you little bastard!!";
    }

    public void LossMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
