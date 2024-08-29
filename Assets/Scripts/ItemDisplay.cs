using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField]
    private int itemIndex;
    [SerializeField]
    private Image image;
    [SerializeField]
    private Button button;

    public void UpdateItemDisplay(Sprite sprite, int newIndex) => (image.sprite, itemIndex) = (sprite, newIndex);

    public void DropFromInventory(InventoryDisplay display) {
        display.DropItem(itemIndex);
    }

    public void EnableItemDisplay(bool enabled = true) {
        image.enabled = enabled;
        button.enabled = enabled;
    }
}
