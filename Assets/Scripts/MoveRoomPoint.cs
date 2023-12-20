using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoomPoint : MonoBehaviour
{
    public void MoveRoom(Transform cameraPosition)
    {
        Camera.main.transform.SetParent(cameraPosition);
        Camera.main.transform.localPosition = Vector3.zero;
    }
    void Start()
    {

    }

    void Update()
    {

    }
}
