using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item.asset", menuName = "Inventory/Item")]
public class Item : ScriptableObject

{
public string itemName;
public int itemID;
public Sprite icon;
public int gold;


public void PrintName()
{
    Debug.Log("Item: " + itemName);
} 
}
