using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeakerUI : MonoBehaviour
{
    public Image portrait;
    public Text fullName;
    public Text dialogue;

    private CharacterScript speaker;
    public CharacterScript Speaker
    { get { return speaker; } 
    set {
        speaker = value;
        portrait.sprite = speaker.portrait;
        fullName.text = speaker.fullName;
        }
    }


public string Dialogue
{   
    get { return dialogue.text;  }
    set { dialogue.text = value; }
}

public bool HasSpeaker()
{
    return speaker != null;
}

public bool SpeakerIs(CharacterScript character)
{
    return speaker == character;
}

public void Show()
{
    gameObject.SetActive(true);
}

    public void Hide()
    {
    gameObject.SetActive(false);
    }
}