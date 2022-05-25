using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FadeScript : MonoBehaviour
{
public string scene = "Scene 1 (uvod)";
public Color loadToColor = Color.green;

public void GoFade()

{

    Initiate.Fade(scene,loadToColor,0.5f);
}


}
