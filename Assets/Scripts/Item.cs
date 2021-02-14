﻿using System;
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

    public Sprite icon;
    public int id;

    public ItemType itemType;
    public string name;

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