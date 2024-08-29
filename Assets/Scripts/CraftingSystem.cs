using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    [SerializeField] 
    private InventorySystem inventory;

    [SerializeField]
    private int maxInput;

    [SerializeField]
    private List<Recipe> _blueprints = new();

    private List<ItemInstance> currentRecipe = new();

    private void Start(){
        Debug.Log(FindBlueprint());
    }

    public CraftingComponent FindBlueprint() {

        List<CraftingComponent> items = new();
        foreach (var instance in currentRecipe) { items.Add(instance.ComponentType); }

        var result = _blueprints.FirstOrDefault(x => x.Components.SequenceEqual(items));

        Debug.Log(result);

        if (!result) return null;
        return result.Result;
    }

    public void Craft()
	{
		List<CraftingComponent> items = new();
		foreach (var instance in currentRecipe) { items.Add(instance.ComponentType); }

		var result = _blueprints.FirstOrDefault(x => x.Components.SequenceEqual(items));
		
        bool success = Random.Range(1, 101) < result.SuccessRate;
        if (success) {
            foreach (var component in currentRecipe) { inventory.RemoveItem(component); }
            inventory.AddItem(new ItemInstance(result.Result));
            }
        result.InvokeEffect(success);
    }
}
