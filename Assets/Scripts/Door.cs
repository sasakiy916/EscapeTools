using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] bool isLock;
    [SerializeField] bool isOpen;
    [SerializeField] GameObject door;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click");
        if (!isOpen) Open();
    }

    public void Open()
    {
        if (!isLock)
        {
            door.transform.Rotate(new Vector3(0, 120, 0));
            isOpen = true;
        }
    }

    public void UnLock()
    {
        isLock = false;
    }

    void Start()
    {
        isOpen = false;
        isLock = true;
    }

    void Update()
    {

    }
}
