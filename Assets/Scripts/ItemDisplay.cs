using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public int itemIndex;
    public Image image;

    public void UpdateItemDisplay(Sprite sprite, int newIndex) => (image.sprite, itemIndex) = (sprite, newIndex);

    public void DropFromInventory(InventoryDisplay display) {
        display.DropItem(itemIndex);
    }
}
