using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Ghost", menuName = "Ghost Library", order = 0)]
public class BookOfSinsState : ScriptableObject {
    
    public int[] bookPage;
    [SerializeField] [TextArea(5,10)] public string[] ghostText;
    
    [SerializeField] Image ghostImage;
    [SerializeField] string[] ghostAtributes;
    

}
