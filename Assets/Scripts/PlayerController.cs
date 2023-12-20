using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    PhysicsRaycaster raycaster;
    void Start()
    {
        raycaster = GetComponent<PhysicsRaycaster>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OpenDoor(Transform door)
    {
        door.Rotate(new Vector3(0, 120, 0));
        Debug.Log("test");
    }
}
