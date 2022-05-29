using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "sinText", menuName = "sinPapers")]
public class SinPaperTextObject : ScriptableObject
{
    [SerializeField] [TextArea(5,10)] public string sinText;
}
