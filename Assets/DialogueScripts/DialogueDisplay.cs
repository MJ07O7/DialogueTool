using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

public class DialogueDisplay : MonoBehaviour
{
    public Conversation conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    private SpeakerUI speakerUILeft;
    private SpeakerUI speakerUIRight;

    private int activeLineIndex;
    private bool conversationStarted = false;


    private void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUI>();

        //   speakerUILeft.Speaker = conversation.speakerLeft;
        // speakerUIRight.Speaker = conversation.speakerRight;
    }

    


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
          
            AdvanceLine(); 
            
        }
    }

    private void AdvanceLine()
    {
        if (conversation == null) return;
        if (!conversationStarted) Initialize();

        if (activeLineIndex < conversation.lines.Length)
            DisplayLine();
        // else
        // AdvanceConversation();
    }

    private void EndConversation()
    {
        conversationStarted = false;
        speakerUILeft.Hide();
        speakerUIRight.Hide();
    }

    private void Initialize()
    {
        conversationStarted = true;
        activeLineIndex = 0;
        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight; 
    }

  

    /*
        private void AdvanceConversation() {
            if (conversation == null) return;
            if (!conversationStarted) Initialize();

            if (activeLineIndex < conversation.lines.Length)
            {
                DisplayLine();
            }
            else
            {
                AdvanceConversation();
            }
        }
    */
    private void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        Character character = line.character;

        if (speakerUILeft.SpeakerIs(character))
        {
            SetDialogue(speakerUILeft, speakerUIRight, line);
        }
        else
        {
            SetDialogue(speakerUIRight, speakerUILeft, line);
        }

        activeLineIndex += 1;
    }
    private void SetDialogue(
        SpeakerUI activeSpeakerUI,
        SpeakerUI inactiveSpeakerUI,
          Line line
    )
    {
        activeSpeakerUI.Show();
        inactiveSpeakerUI.Hide();

        activeSpeakerUI.Dialogue = "";


        StopAllCoroutines();
        StartCoroutine(EffectTypewriter(line.text, activeSpeakerUI));
    }

    private IEnumerator EffectTypewriter(string text, SpeakerUI controller)
    {
        foreach (char character in text.ToCharArray())
        {
            controller.Dialogue += character;
            yield return new WaitForSeconds(0.05f);
            // yield return null;
        }
    }
}
