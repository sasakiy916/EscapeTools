using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NumberRock))]
public class NumberRockEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        NumberRock numberRock = (NumberRock)target;
        numberRock.SetNumbers();
    }
}