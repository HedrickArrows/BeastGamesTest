using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

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
    [SerializeField]
    private Button craftButton;

    private void Start() {
        UpdateDisplay();
    }

	private void OnEnable()	{
		UpdateDisplay(); 
	}

	private void OnDisable() {
		crafting.ClearCurrent();
	}

	public void UpdateDisplay() {
        for (int i = 0; i < selectedComponents.Length; i++) {
            if (i < crafting.CurrentRecipe.Count) {
                selectedComponents[i].EnableItemDisplay();
                selectedComponents[i].UpdateItemDisplay(crafting.CurrentRecipe[i].ComponentType.Icon, i);
            } else {
				selectedComponents[i].EnableItemDisplay(false);
			}
        }

        var result = crafting.FindBlueprint();
        if (result) {
            potentialResult.EnableItemDisplay();
            potentialResult.UpdateItemDisplay(result.Result.Icon, -1);
            chancesDisplay.text = result.SuccessRate.ToString() + "%";
            craftButton.interactable = true;
        } else {
            potentialResult.EnableItemDisplay(false);
            chancesDisplay.text = "";
			craftButton.interactable = false;

		}
    }
}
