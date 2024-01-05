using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public int positionIndex;
    public Transform[] cameraPositions;

    public void MovePosition()
    {
        positionIndex = ++positionIndex % cameraPositions.Length;
        Camera.main.transform.SetParent(cameraPositions[positionIndex]);
        Camera.main.transform.localPosition = Vector3.zero;
        Camera.main.transform.localRotation = Quaternion.identity;
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
