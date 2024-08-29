using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Recipe : ScriptableObject
{
	[SerializeField] 
	private List<CraftingComponent> components;
	[SerializeField] 
	private CraftingComponent result;
	[SerializeField, Range(0, 100)]
	private float successRate;
	[SerializeField]
	private UnityEvent onSuccessEvent;
	[SerializeField]
	private UnityEvent onFailureEvent;

	public List<CraftingComponent> Components => components;

	public CraftingComponent Result => result;

	public float SuccessRate => successRate;

	public void InvokeEffect(bool positive = true) { 
		if (positive) onSuccessEvent?.Invoke();
		else onFailureEvent?.Invoke();
	}
}
