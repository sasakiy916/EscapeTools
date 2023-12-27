using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CameraController))]
public class CameraControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("ボタン"))
        {
            CameraController cameraController = (CameraController)target;
            cameraController.transform.Rotate(0, 90, 0);
        }
    }
}