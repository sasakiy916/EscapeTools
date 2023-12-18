using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] Image[] itemSlots;
    [SerializeField] Transform itemListPanel;
    public Image[] ItemSlots
    {
        get => itemSlots;
        set { itemSlots = value; }
    }
    public Transform ItemListPanel
    {
        get => itemListPanel;
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
