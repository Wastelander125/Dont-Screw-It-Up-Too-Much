using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ghosts : MonoBehaviour
{
    [SerializeField] SpriteRenderer ghostImage;
    [SerializeField] TextMeshProUGUI sinPaper;
    [SerializeField] public GhostPortraits[] portraits;

    [SerializeField] SinPaperTextObject[] sinPaperObject;
    [SerializeField] Button confirmationButton;

    public int ghostNumber = 0;
    [SerializeField] int paperNumber = 0;
    [SerializeField] int right = 0;
    [SerializeField] int wrong = 0;


    // Start is called before the first frame update
    void Start()
    {
        sinPaper.text = sinPaperObject[paperNumber].sinText;
        ghostImage.sprite = portraits[ghostNumber].ghostPortraitImages;        
    }

    // Update is called once per frame
    void Update()
    {
        if(paperNumber <= portraits.Length - 1)
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
        
            ghostNumber++;
            paperNumber++;
        
    }

    public void Decicions()
    {
        
        if(right >= 5)
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
        if(ghostNumber == 1)
        {
            wrong++;
        }
        if(ghostNumber == 2)
        {
            right++;
        }
        if(ghostNumber == 3)
        {
            right++;
        }
        if(ghostNumber == 4)
        {
            wrong++;
        }
        if(ghostNumber == 5)
        {
            wrong++;
        }
        if(ghostNumber == 6)
        {
            wrong++;
        }
        if(ghostNumber == 7)
        {
            right++;
        }
        
    }
    public void Hell()
    {
        if(ghostNumber == 1)
        {
            right++;
        }
        if(ghostNumber == 2)
        {
            wrong++;
        }
        if(ghostNumber == 3)
        {
            wrong++;
        }
        if(ghostNumber == 4)
        {
            right++;
        }
        if(ghostNumber == 5)
        {
            right++;
        }
        if(ghostNumber == 6)
        {
            right++;
        }
        if(ghostNumber == 7)
        {
            wrong++;
        }
    }
}
