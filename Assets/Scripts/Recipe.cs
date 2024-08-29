using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Recipe : ScriptableObject
{
	[SerializeField] 
	private List<CraftingComponent> components;
	[SerializeField] 
	private CraftingComponent result;

	public List<CraftingComponent> Components => components;

	public CraftingComponent Result => result;
}
