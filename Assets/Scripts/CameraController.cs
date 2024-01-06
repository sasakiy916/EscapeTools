using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public int positionIndex;
    public Transform[] cameraPositions;

    public void MovePosition()
    {
        // 親の設定（カメラの移動先）
        positionIndex = ++positionIndex % cameraPositions.Length;
        Camera.main.transform.SetParent(cameraPositions[positionIndex]);
        // ローカル座標などを初期化
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;
        Camera.main.transform.localScale = Vector3.one;
    }

    public void RotateCameraPosition()
    {
        cameraPositions[positionIndex].Rotate(0.0f, 90.0f, 0.0f);
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
