using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] bool isOpen;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click");
        if (isOpen) Open();
    }

    public void Open()
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
