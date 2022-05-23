using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ghosts : MonoBehaviour
{
    [SerializeField] SpriteRenderer ghostImage;
    [SerializeField] TextMeshProUGUI sinPaper;
    [SerializeField] GhostPortraits[] portraits;

    [SerializeField] SinPaperTextObject[] sinPaperObject;

    [SerializeField] int ghostNumber = 0;
    [SerializeField] int paperNumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        sinPaper.text = sinPaperObject[paperNumber].sinText;
        ghostImage.sprite = portraits[ghostNumber].ghostPortraitImages;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(paperNumber <= 4)
        {
            sinPaper.text = sinPaperObject[paperNumber].sinText;
            ghostImage.sprite = portraits[ghostNumber].ghostPortraitImages;
        }
        else
        {
            return;
        }
        
    }

    public void GhostCycling()
    {
        
            ghostNumber++;
            paperNumber++;
        
    }

}
