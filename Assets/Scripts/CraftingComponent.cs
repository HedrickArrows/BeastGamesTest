using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingComponent : ScriptableObject
{
	[SerializeField] public string resourceName { get; private set; }
}
