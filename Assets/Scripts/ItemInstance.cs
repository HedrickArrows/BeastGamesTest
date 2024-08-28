using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
	public CraftingComponent componentType;

	public ItemInstance(CraftingComponent componentType){
		this.componentType = componentType; 
	}
}
