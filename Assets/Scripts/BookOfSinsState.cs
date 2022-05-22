using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Ghost", menuName = "Ghost Library", order = 0)]
public class BookOfSinsState : ScriptableObject {
    
    [SerializeField] int[] bookPage;
    [SerializeField] string[] bookText;
    

}
