using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CraftingDisplay : MonoBehaviour
{
    [SerializeField]
    private CraftingSystem crafting;

    [SerializeField]
    private ItemDisplay[] selectedComponents;
    [SerializeField]
    private ItemDisplay potentialResult;
    [SerializeField]
    private TextMeshProUGUI chancesDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDisplay() {

    }
}
