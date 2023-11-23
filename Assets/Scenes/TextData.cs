using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TextData_" , menuName = "TextData/Text")]

public class TextData : ScriptableObject
{
    [Header("Text Input")]
    [SerializeField]
    private string _YourTextHere;

    [Header("Text Settings")]
    [SerializeField]
    [Range(0,100)]
    private float _textSize;

    [Header("TextBox Settings")]
    //[SerializeField]
    //determine shape of text box

    //color

    //location

    [SerializeField]
    private float _durationOnScreen;
}