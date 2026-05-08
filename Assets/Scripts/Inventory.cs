using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<ItemData> items = new List<ItemData>();
    public ItemData selectedItem;

    private void Awake()
    {
        Instance = this;
    }

    public void AddItem(ItemData item)
    {
        items.Add(item);
        Debug.Log("Picked up: " + item.itemName);
    }

    public void SelectItem(ItemData item)
    {
        selectedItem = item;
        Debug.Log("Selected: " + item.itemName);
    }

    public void RemoveItem(ItemData item)
    {
        items.Remove(item);
        if (selectedItem == item)
            selectedItem = null;
    }
}