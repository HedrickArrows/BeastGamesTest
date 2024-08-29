using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CraftingScript : MonoBehaviour
{
    private List<Recipe> _blueprints;

    // Start is called before the first frame update
    private void Start(){
		_blueprints = new();

        Debug.Log(FindBlueprint(new List<CraftingComponent>()));
    }

    private void Update(){
        
    }

    public CraftingComponent FindBlueprint(List<CraftingComponent> input) {

        var result = _blueprints.FirstOrDefault(x => x.Components.SequenceEqual(input));

        Debug.Log(result);

        if (result.Equals(default)) return null;
        return result.Result;
    }
}
