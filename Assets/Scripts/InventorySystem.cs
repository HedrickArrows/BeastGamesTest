using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour{

    public List<ItemInstance> items = new();


    public void AddItem(ItemInstance item) { 
        items.Add(item); 
    }

    public void RemoveItem(ItemInstance item) { 
        items.Remove(item); 
    }
}
