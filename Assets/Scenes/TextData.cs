using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TextData_" , menuName = "TextData/Text")]

public class TextData : ScriptableObject
{
    [Header("Text Input")]
        private string _YourTextHere;

    [Header("Text Settings")]
    [SerializeField]
    [Range(0,100)]
    private float _textSize;
}
