using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowMe : MonoBehaviour
{
    [SerializeField] Canvas showCanvas;
    [SerializeField] TextMeshProUGUI closeUpText;
    [SerializeField] BookOfSinsState[] state;
    [SerializeField] int pageNumber = 1;
    [SerializeField] int bookNumber = 0;
    [SerializeField] int currentBookMaxPageNumbers = 0;
    [SerializeField] Image bookImage;
    [SerializeField] Sprite closedBook;
    [SerializeField] Sprite openBook;

    // Start is called before the first frame update
    void Awake()
    {
        showCanvas.gameObject.SetActive(false);
        closeUpText.text = state[bookNumber].ghostText[pageNumber];
        bookImage.sprite = closedBook;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentBookMaxPageNumbers = state[bookNumber].ghostText.Length;
        if(pageNumber >= 1 && pageNumber <= currentBookMaxPageNumbers - 1)
        {
            closeUpText.text = state[bookNumber].ghostText[pageNumber];
        }
        else
        {
            return;
        }
        
    }

    public void ShowBookPages()
    {
        showCanvas.gameObject.SetActive(true);
        bookImage.sprite = openBook;
    }

    public void CloseBook()
    {
        showCanvas.gameObject.SetActive(false);
        bookImage.sprite = closedBook;
    }

    public void NextPage()
    {
        if(pageNumber <= currentBookMaxPageNumbers - 1)
        {
            pageNumber++;
        }
        
       
    }
    public void PreviousPage()
    {
        if(pageNumber > 1)
        {
            pageNumber--;
        }
        
    }

    public void HeavenAndHell()
    {
        
        if(bookNumber <= state.Length -2)
        {
            bookNumber++;
            pageNumber = 1;
        }
        

    }

}
