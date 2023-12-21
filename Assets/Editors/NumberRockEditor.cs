using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NumberRock))]
public class NumberRockEditor : Editor
{
    NumberRock numberRock;
    void OnEnable()
    {
        numberRock = (NumberRock)target;
        EditorApplication.hierarchyChanged += numberRock.AttachNumberTextObject;
    }

    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();

        base.OnInspectorGUI();

        if (EditorGUI.EndChangeCheck())
        {
            numberRock.SetNumbers();
        }
    }
}
