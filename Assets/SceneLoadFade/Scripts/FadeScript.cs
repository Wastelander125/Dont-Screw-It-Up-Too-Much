using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FadeScript : MonoBehaviour
{
public string scene = "Scene 1 (uvod)";
public Color loadToColor = Color.green;

private AudioSource _music;

public void GoFade()

{

    Initiate.Fade(scene,loadToColor,0.5f);

    if (_music == null)
        return;

    _music.Play();
}

private void Awake() 

{
       
    _music = GetComponent<AudioSource>();
}


}
