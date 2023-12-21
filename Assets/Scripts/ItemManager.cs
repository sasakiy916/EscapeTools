using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] ItemSlot[] itemSlots;
    [SerializeField] Transform itemListPanel;
    public ItemSlot[] ItemSlots
    {
        get => itemSlots;
        set { itemSlots = value; }
    }
    public Transform ItemListPanel
    {
        get => itemListPanel;
    }

    public void PickUp(Item item)
    {
        foreach (ItemSlot slot in itemSlots)
        {
            if (slot.Set(item)) return;
        }
    }

    void Start()
    {
    }

    void Update()
    {

    }
}
