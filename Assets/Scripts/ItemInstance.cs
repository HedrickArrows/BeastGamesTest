using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
	[SerializeField]
	private CraftingComponent componentType;

	public CraftingComponent ComponentType => componentType;

	public ItemInstance(CraftingComponent componentType){
		this.componentType = componentType; 
	}
}
