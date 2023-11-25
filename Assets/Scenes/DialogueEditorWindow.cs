using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class DialogueEditorWindow : EditorWindow
{
    string stringToEdit = "Write Dialogue Here";

    [MenuItem("Window/DialogueEditing")]
        public static void ShowWindow()
    {
        GetWindow<DialogueEditorWindow>("Dialogue Window");
    }

    private void OnGUI()
    {
        EditorGUILayout.Space();
        GUILayout.Label("Insert Text Here");
        
        EditorGUILayout.Space();

        //    stringToEdit = GUILayout.TextField(stringToEdit);
            stringToEdit = EditorGUI.TextArea(new Rect(20, 30, position.width - 600, position.height - 750), stringToEdit);

       
       // GUILayout.Label("Speed of Text");
        //EditorGUI.LabelField (new Rect(300));
    }
}
/*
if (GUILayout.Button("Click Me"))
{
    //code runs whem button is clicked
}
*/