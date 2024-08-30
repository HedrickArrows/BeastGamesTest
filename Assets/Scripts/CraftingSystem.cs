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

    [SerializeField]
    private List<ItemInstance> currentRecipe = new();

    public List<ItemInstance> CurrentRecipe => currentRecipe;

    private void Start(){
        Debug.Log(FindBlueprint());
    }

    public void TryAddComponent(int index) {
        ItemInstance item = inventory.GetItem(index);
        if(currentRecipe.Contains(item)) { currentRecipe.Remove(item); return; }
        if (currentRecipe.Count >= maxInput) { return; }
        currentRecipe.Add(item);
    }

    public void ClearCurrent() { 
        currentRecipe.Clear();
    }

    public Recipe FindBlueprint() {

        List<CraftingComponent> items = new();
        foreach (var instance in currentRecipe) { items.Add(instance.ComponentType); }

        var result = _blueprints.FirstOrDefault(x => x.Components.SequenceEqual(items));

        Debug.Log(result);

        if (!result) return null;
        return result;
    }

    public void Craft()
	{
		List<CraftingComponent> items = new();
		foreach (var instance in currentRecipe) { items.Add(instance.ComponentType); }

		var result = _blueprints.FirstOrDefault(x => x.Components.SequenceEqual(items));
		
        bool success = Random.Range(1, 101) <= result.SuccessRate;
        if (success) {
            foreach (var component in currentRecipe) { inventory.RemoveItem(component); }
            inventory.AddItem(new ItemInstance(result.Result));
            }
        result.InvokeEffect(success);

        foreach (var component in currentRecipe) { inventory.RemoveItem(component); }

        ClearCurrent();
    }
}
