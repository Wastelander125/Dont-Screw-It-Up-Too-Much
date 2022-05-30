using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerForGhostLineText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] ghostsInLineTexts;
    [SerializeField] Image[] textBubbles;
    string[] swearTexts = {"Beep beep", "Hey what's going on", "Move on snail!", "Oh, where am I", "Oh no dead again", "Ahh I see the stars", "It's like vacation with group of Germans", "Hey, watch out", "I am on the Highway to Hell...", 
    "I'm buying Stairway to Heaven.","That does not look like Valhall", "Heh that guy thought he can kill me.. oh...", "So... the dogs that bark also bite? Damn!","Lesson learned... you surely cannot fly", "Smoke me a kipper, I'll be back for breakfast",
    "Please... I'm electrician i know how to do it.", "This waiting is killing me", "Aaaarggghhhh...Oh, where is the battle and why it is so bright there?", "I shouldn't eat that mushroom", "Come here bear i don't bite",
     "Maybe telling her she is fat was not good idea.", "When I give up I give up, shooting isn't necessary"};
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
