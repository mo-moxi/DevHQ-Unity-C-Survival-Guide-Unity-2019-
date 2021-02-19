using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item.asset", menuName = "Inventory/Item/Equiptable")]
public class Equiptable : Item
{
    public int attack, strength, defense, prayer;
}
