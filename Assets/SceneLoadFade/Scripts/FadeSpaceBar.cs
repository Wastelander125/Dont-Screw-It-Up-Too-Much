using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSpaceBar : MonoBehaviour
{
    // Start is called before the first frame update

    public string scene = "GameScene 2(Vlada)";
    public Color loadToColor = Color.white;


    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            GoFade();
        }
    }


    public void GoFade()

    {
    Initiate.Fade(scene,loadToColor,0.5f);
    }
}
