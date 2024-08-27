using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CraftingScript : MonoBehaviour
{
    Dictionary<Craftable, List<Craftable>> _blueprints; //mo¿liwe do przerobienia na List<KeyValuePair<>> zamiast Dictionary<> w wypadku rzeczy do stworzenia z kilku ró¿nych przepisów

    // Start is called before the first frame update
    private void Start(){
		_blueprints = new Dictionary<Craftable, List<Craftable>>();

        Debug.Log(FindBlueprint(new List<Craftable>()));
    }

    void Update(){
        
    }

    public Craftable FindBlueprint(List<Craftable> input) {

        var result = _blueprints.FirstOrDefault(x => x.Value.SequenceEqual(input));

        Debug.Log(result);

        if (result.Equals(default)) return null;
        return result.Key;
    }
}
