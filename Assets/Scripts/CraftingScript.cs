using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CraftingScript : MonoBehaviour
{
    Dictionary<CraftingComponent, List<CraftingComponent>> _blueprints; //mo¿liwe do przerobienia na List<KeyValuePair<>> zamiast Dictionary<> w wypadku rzeczy do stworzenia z kilku ró¿nych przepisów

    // Start is called before the first frame update
    private void Start(){
		_blueprints = new Dictionary<CraftingComponent, List<CraftingComponent>>();

        Debug.Log(FindBlueprint(new List<CraftingComponent>()));
    }

    private void Update(){
        
    }

    public CraftingComponent FindBlueprint(List<CraftingComponent> input) {

        var result = _blueprints.FirstOrDefault(x => x.Value.SequenceEqual(input));

        Debug.Log(result);

        if (result.Equals(default)) return null;
        return result.Key;
    }
}
