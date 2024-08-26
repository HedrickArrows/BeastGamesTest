using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CraftingScript : MonoBehaviour
{
    Dictionary<Craftable, List<Craftable>> _recipes; //mo¿liwe do przerobienia na List<KeyValPair<>> zamiast Dictionary w wypadku przepisów

    // Start is called before the first frame update
    void Start()
    {
        _recipes = new Dictionary<Craftable, List<Craftable>>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Craftable FindBlueprint(List<Craftable> input) {

        var result = _recipes.FirstOrDefault(x => x.Value.SequenceEqual(input));

        Debug.Log(result);

        if (result.Equals(default)) return null;
        return result.Key;
    }
}
