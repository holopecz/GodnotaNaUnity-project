using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUnlock : MonoBehaviour
{
    [SerializeField] private GameObject item;
    public void UnlockItem()
    {
        item.SetActive(true);
    }
}
