using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour{

    [SerializeField]
    private List<ItemInstance> items = new();

    public int ItemsCount => items.Count;
    public ItemInstance GetItem(int index) => items[index];


	public void AddItem(ItemInstance item) { 
        items.Add(item); 
    }

    public void RemoveItem(ItemInstance item) { 
        items.Remove(item); 
    }

    public void RemoveItem(int index) { 
        items.RemoveAt(index);  
    }
}
