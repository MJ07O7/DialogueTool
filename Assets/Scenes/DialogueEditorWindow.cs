using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DialogueEditorWindow : EditorWindow
{
    public string[] stringToEdit;
    float scale = 1.0f;
    public Color textBoxColor;

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

     
       //stringToEdit = EditorGUI.TextArea(new Rect(20, 30, position.width - 600, position.height - 750), stringToEdit);

        GUI.Label(new Rect(5, 170, 100, 20), "Text Speed");
        ;
        scale = EditorGUI.Slider(new Rect(100, 170, 150, 20), scale, 1, 5);
    }
}
/*
if (GUILayout.Button("Click Me"))
{
    //code runs whem button is clicked
}
*/