using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeOutText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeOutTextField;

    int rightNumber;
    int wrongNumber;
    int completedTasks;

    private void Awake() 
    {
        rightNumber = Ghosts.right;
        wrongNumber = Ghosts.wrong;
        completedTasks = Ghosts.actualGhostNumber;
    }

    void Start()
    {
        timeOutTextField.text = "Well I am back. Looks like you did not finish all ten people from the list. Lets have a look. You did " + rightNumber + " right choices and " + wrongNumber + " bad choices from total of " + completedTasks + " people";
    }


}
