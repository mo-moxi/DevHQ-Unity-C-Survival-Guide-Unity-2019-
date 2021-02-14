using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType
    {
        none,
        Weapon,
        Consumable
    }
    public string name;
    public int id;
    public Sprite icon;
    public String description;
    public ItemType itemType;


    public void Action()
    {
        switch (itemType)
        {
            case ItemType.Weapon:
                Debug.Log("This is a " + itemType);
                break;
            case ItemType.Consumable:
                Debug.Log("This is a " + itemType);
                break;
        }
    }
}