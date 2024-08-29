using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField]
    private InventorySystem inventory;
	[SerializeField]
	private InventoryDisplay display;


	private void OnTriggerEnter(Collider other)	{
		Debug.Log("Touched " + other.name);
		if (other.TryGetComponent(out ItemContainer container) && display.HasSpace)	{
			inventory.AddItem(container.TakeItem());
			display.UpdateInventory();
		}
	}

	public void DropItem(int index)
	{
		var item = inventory.GetItem(index);
		GameObject itemModel = Instantiate(item.componentType.Model,transform.position + transform.forward * 2 + Vector3.up, Quaternion.identity);

		inventory.RemoveItem(index);

		display.UpdateInventory();
	}

}
