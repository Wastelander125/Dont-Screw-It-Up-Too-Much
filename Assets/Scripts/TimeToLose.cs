using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;
 
public class TimeToLose : MonoBehaviour
{
    [SerializeField] float remainingTime = 20;
    [SerializeField] TextMeshProUGUI showRemainingTime;
    [SerializeField] AudioSource gameMusicNormal;
    [SerializeField] AudioSource gameMusicFast;
    
 

    private void Update() 
    {
        UpdateTimer();
        showRemainingTime.text = "Remaining Time: " + Mathf.Round(remainingTime);

        if(remainingTime <= 0)
        {
            showRemainingTime.gameObject.SetActive(false);
            StartCoroutine(WaitNextScene());
            SceneManager.LoadScene(6);

        }

        if(remainingTime <= 90)
        {
            gameMusicNormal.gameObject.SetActive(false);
            gameMusicFast.gameObject.SetActive(true);
        }

    }

    void UpdateTimer()
    {
        remainingTime -= Time.deltaTime;
    }

    IEnumerator WaitNextScene()
    {
        yield return new WaitForSeconds(1f);
    }

    

}
