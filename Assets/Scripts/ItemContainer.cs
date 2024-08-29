using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    [SerializeField]
    private ItemInstance item;

    public ItemInstance Item => item;

    public ItemInstance TakeItem() {
        Destroy(gameObject);
        return item;
    }
}
