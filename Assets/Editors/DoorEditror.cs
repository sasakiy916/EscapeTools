using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Door))]
public class DoorEditror : Editor
{
    Door door;
    void OnEnable()
    {
        door = (Door)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        // if (GUILayout.Button("sasaki"))

    }
}