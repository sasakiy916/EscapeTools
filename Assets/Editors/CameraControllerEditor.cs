using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CameraController))]
public class CameraControllerEditor : Editor
{
    CameraController cameraController;
    void OnEnable()
    {
        cameraController = (CameraController)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("90度回転"))
        {
            // cameraController.transform.parent.Rotate(0, 90, 0);
            cameraController.RotateCameraPosition();
        }

        if (GUILayout.Button("部屋移動"))
        {
            cameraController.MovePosition();
        }
    }
}