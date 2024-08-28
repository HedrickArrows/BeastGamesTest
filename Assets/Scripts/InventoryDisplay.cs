using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryDisplay : MonoBehaviour
{
    public InventorySystem inventory;
	public ItemDisplay[] slots;
	[SerializeField]
	private PlayerInventory playerInventory;
    

    void Start(){
        UpdateInventory();
    }

    public void UpdateInventory() {
		for (int i = 0; i < slots.Length; i++) {
			if (i < inventory.items.Count) {
				slots[i].gameObject.SetActive(true);
				slots[i].UpdateItemDisplay(inventory.items[i].componentType.Icon, i);
			}
			else { 
				slots[i].gameObject.SetActive(false);
			}
		}
    }

	public void DropItem(int index) => playerInventory.DropItem(index);

}
