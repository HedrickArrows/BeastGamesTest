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
		if (other.TryGetComponent(out ItemContainer container))	{
			inventory.AddItem(container.TakeItem());
			display.UpdateInventory();
		}
	}

	public void DropItem(int index)
	{
		var item = inventory.items[index];
		GameObject droppedItem = new GameObject(inventory.items[index].componentType.ComponentName);
		droppedItem.transform.position = transform.position + transform.forward * 2 + Vector3.up;
		droppedItem.AddComponent<Rigidbody>();
		droppedItem.AddComponent<SphereCollider>().isTrigger = true;
		droppedItem.AddComponent<ItemContainer>().item = inventory.items[index];
		GameObject itemModel = Instantiate(inventory.items[index].componentType.Model, droppedItem.transform);

		inventory.items.RemoveAt(index);

		display.UpdateInventory();
	}

}
