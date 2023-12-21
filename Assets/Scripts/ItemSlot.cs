using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    Image image;
    Item item;
    public bool Set(Item item)
    {
        if (this.item != null) return false;
        this.item = item;
        image.sprite = this.item.sprite;
        return true;
    }
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {

    }
}
