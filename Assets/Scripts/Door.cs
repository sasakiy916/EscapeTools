using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool isOpen;
    public void OpenDoor()
    {
        if (!isOpen) transform.Rotate(new Vector3(0, 120, 0));
    }
    void Start()
    {

    }

    void Update()
    {

    }
}
