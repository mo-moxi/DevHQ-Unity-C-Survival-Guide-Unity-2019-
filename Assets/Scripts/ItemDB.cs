using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    
    void Start()
    {
        itemDictionary.Add(0, itemList[0]);

        var item = itemDictionary[0];
        Debug.Log("Item at key 0 is: "+ item.name);
    }
    
    void Update()
    {
        
    }
}
