using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> itemDataBase;

    void Start()
    {
        itemDataBase.ForEach(i => i.PrintName());
    }
}
