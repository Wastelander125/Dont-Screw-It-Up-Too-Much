using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ghosts : MonoBehaviour
{
    [SerializeField] Image ghostImage;
    [SerializeField] TextMeshProUGUI sinPaper;
    [SerializeField] public GhostPortraits[] portraits;

    [SerializeField] SinPaperTextObject[] sinPaperObject;
    [SerializeField] Button confirmationButton;
    [SerializeField] int numberOfGhosts = 10;

    public int ghostNumber;
    public int actualGhostNumber = 0;
    [SerializeField] int paperNumber = 0;
    public static int right = 0;
    public static int wrong = 0;

    [SerializeField] int counterRight = 0;
    [SerializeField] int counterWrong = 0;

    // Start is called before the first frame update
    void Start()
    {
        ghostNumber = Random.Range(0,5);
        sinPaper.text = sinPaperObject[paperNumber].sinText;
        ghostImage.sprite = portraits[ghostNumber].ghostPortraitImages;        
    }

    // Update is called once per frame
    void Update()
    {
        if(paperNumber <= numberOfGhosts - 1)
        {
            sinPaper.text = sinPaperObject[paperNumber].sinText;
            ghostImage.sprite = portraits[ghostNumber].ghostPortraitImages;
            
        }
        else
        {
            confirmationButton.gameObject.SetActive(true);
            
        }
    }

    public void GhostCycling()
    {
            paperNumber++;
            actualGhostNumber++;
            ghostNumber = Random.Range(0,5);
        
    }

    public void Decicions()
    {
        
        if(right > wrong)
        {
            SceneManager.LoadScene(5);
        }
        else
        {
            SceneManager.LoadScene(6);
        }
    
    }

    public void Heaven()
    {
        if(actualGhostNumber == 1)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 2)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 3)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 4)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 5)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 6)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 7)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 8)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 9)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 10)
        {
            wrong++;
            counterWrong++;
        }
        
    }
    public void Hell()
    {
        if(actualGhostNumber == 1)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 2)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 3)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 4)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 5)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 6)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 7)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 8)
        {
            wrong++;
            counterWrong++;
        }
        if(actualGhostNumber == 9)
        {
            right++;
            counterRight++;
        }
        if(actualGhostNumber == 10)
        {
            right++;
            counterRight++;
        }
    }

    
}
