using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryDisplay : MonoBehaviour
{
	[SerializeField]
    private InventorySystem inventory;
	[SerializeField]
	private ItemDisplay[] slots;
	[SerializeField]
	private PlayerInventory playerInventory;
    

    private void Start(){
        UpdateInventory();
    }

	private void OnEnable() {
		UpdateInventory();
	}

	public bool HasSpace => inventory.ItemsCount < slots.Length;

    public void UpdateInventory() {
		for (int i = 0; i < slots.Length; i++) {
			if (i < inventory.ItemsCount) {
				slots[i].EnableItemDisplay();
				slots[i].UpdateItemDisplay(inventory.GetItem(i).ComponentType.Icon, i);
			}
			else { 
				slots[i].EnableItemDisplay(false);
			}
		}
    }

	public void DropItem(int index) => playerInventory.DropItem(index);

}
