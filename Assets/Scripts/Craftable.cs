using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craftable : ScriptableObject
{
	[SerializeField] public string resourceName { get; private set; }
}
