using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowMe : MonoBehaviour
{
    [SerializeField] Canvas showCanvas;
    BookOfSinsState sinsState;
    [SerializeField] TextMeshProUGUI closeUpText;
    [SerializeField] BookOfSinsState state;
    [SerializeField] int pageNumber = 1;

    // Start is called before the first frame update
    void Awake()
    {
        showCanvas.gameObject.SetActive(false);
        closeUpText.text = state.ghostText[pageNumber];
    }

    // Update is called once per frame
    void Update()
    {
        if(pageNumber >= 1 && pageNumber != 4)
        {
            closeUpText.text = state.ghostText[pageNumber];
            NextPage();
            PreviousPage();
        }
        else
        {
            return;
        }
        
    }

    public void ShowBookPages()
    {
        showCanvas.gameObject.SetActive(true);
    }

    public void CloseBook()
    {
        showCanvas.gameObject.SetActive(false);
    }

    public void NextPage()
    {
        if(pageNumber <= 3)
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
}
