using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NumberRock))]
public class NumberRockEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();

        base.OnInspectorGUI();
        NumberRock numberRock = (NumberRock)target;

        if (EditorGUI.EndChangeCheck())
        {
            numberRock.AttachNumberTextObject();
            numberRock.SetNumbers();
        }
    }
}