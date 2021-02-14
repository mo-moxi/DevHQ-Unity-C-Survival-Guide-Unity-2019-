using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public string description;
    public Sprite image;

    public enum ItemType
    {
        Weapon,
        Consumable,
        None
    }

    public ItemType itemType;
}
