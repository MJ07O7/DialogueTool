using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeakerUI : MonoBehaviour
{
    public Image portrait;

    [SerializeField]
    public TMP_Text fullName;

    [SerializeField]
    public TMP_Text dialogue;

    private Character speaker;
    public Character Speaker
    { 
        get { return speaker; } 
        set {
      speaker = value;
      portrait.sprite = speaker.portrait;
      fullName.text = speaker.fullName;
            Debug.Log("There is no picture");
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

public bool SpeakerIs(Character character)
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
