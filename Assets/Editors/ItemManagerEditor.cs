using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;


[CustomEditor(typeof(ItemManager))]
public class ItemManagerEditor : Editor
{
    public ItemManager itemManager;
    int itemSlotCount;

    void OnEnable()
    {
        itemManager = (ItemManager)target;
    }
    public override void OnInspectorGUI()
    {
        EditorGUI.BeginChangeCheck();

        base.OnInspectorGUI();
        if (EditorGUI.EndChangeCheck() || itemSlotCount != itemManager.ItemListPanel.childCount)
        {
            // ItemManager itemManager = (ItemManager)target;

            // 全てのItemSlotにあるImageコンポーネントを取得
            List<Image> itemSlotsList = new();
            Image[] itemSlots = itemManager.ItemListPanel.GetComponentsInChildren<Image>();
            foreach (Image itemSlot in itemSlots)
            {
                if (itemSlot.transform == itemManager.ItemListPanel) continue;
                itemSlotsList.Add(itemSlot);
            }
            itemManager.ItemSlots = itemSlotsList.ToArray();
        }

    }
}