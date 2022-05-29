using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerForGhostLineText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] ghostsInLineTexts;
    [SerializeField] Image[] textBubbles;
    string[] swearTexts = {"beep beep", "Hey what is going on", "Move on snail", "Oh where am I", "Oh no dead again", "Nevim", "Dalsi text", "Hey"};
    float nextActionTime;
    public float period = 2;
    int randomField;
    int randomText;
    bool showText = true;

    // Start is called before the first frame update
    void Start()
    {
        randomField = Random.Range(0,ghostsInLineTexts.Length);
        randomText = Random.Range(0,swearTexts.Length);
        StartCoroutine(TimerForText()); 

    }

    // Update is called once per frame
    void Update()
    {
        if(showText == true)
        {
            randomField = Random.Range(0,ghostsInLineTexts.Length);
            randomText = Random.Range(0,swearTexts.Length);
            
        }
        else
        {
            return;
        }
    }

    IEnumerator TimerForText()
    {
        yield return new WaitForSeconds(2f);
        ghostsInLineTexts[randomField].gameObject.SetActive(true);
        textBubbles[randomField].gameObject.SetActive(true);
        ghostsInLineTexts[randomField].text = swearTexts[randomText];
        showText = false;
        yield return new WaitForSeconds(3f);
        ghostsInLineTexts[randomField].gameObject.SetActive(false);
        textBubbles[randomField].gameObject.SetActive(false);
        yield return new WaitForSeconds(3f);
        showText = true;
        yield return new WaitForSeconds(0.1f);
        yield return StartCoroutine(TimerForText());
        
           
        

    }

}
