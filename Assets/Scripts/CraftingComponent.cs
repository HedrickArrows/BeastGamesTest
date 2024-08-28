using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu]
public class CraftingComponent : ScriptableObject
{
	[SerializeField]
	private string componentName;
	[SerializeField]
	private Sprite icon;
	[SerializeField]
	private GameObject model;
	[TextArea, SerializeField] 
	private string description;

	public string ComponentName => componentName;
	public Sprite Icon => icon;
	public GameObject Model => model;
	public string Description => description;
}
