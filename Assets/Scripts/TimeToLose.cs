using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
 
public class TimeToLose : MonoBehaviour
{
    [SerializeField] float remainingTime = 20;
    [SerializeField] TextMeshProUGUI showRemainingTime;
 

    private void Update() 
    {
        UpdateTimer();
        showRemainingTime.text = "Remaining Time: " + Mathf.Round(remainingTime);

        if(remainingTime <= 0)
        {
            showRemainingTime.gameObject.SetActive(false);
            StartCoroutine(WaitNextScene());
            SceneManager.LoadScene(7);

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
