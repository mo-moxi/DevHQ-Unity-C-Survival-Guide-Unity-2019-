using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    
    void Start()
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            itemDictionary.Add(i, itemList[i]);
        }
    }
    void Update()
    {
        // always check that key exists before access 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var i = Random.Range(0, itemDictionary.Count);
            var item = itemDictionary[i];
            Debug.Log("Item at key is " + i +" and item is "+ item.name);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            foreach(KeyValuePair<int, Item> item in itemDictionary)
                Debug.Log("Item at key " + item.Key +" is: "+ item.Value.name);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            foreach(var key in itemDictionary.Keys)
                Debug.Log("Item at keys " + key);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            foreach(var item in itemDictionary.Values)
                Debug.Log("Item at keys " + item.name);
        }
        // Assign random found item
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (itemDictionary.ContainsKey(5))
            {
                var randomItem = itemDictionary[5];
                Debug.Log("You found key ");
            }
            else
            {
                Debug.Log("Key does not exist");
            }
        }
    }
}
