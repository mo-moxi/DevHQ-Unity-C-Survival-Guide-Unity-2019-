using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    [SerializeField] private readonly List<Item> itemDatabase = new List<Item>();

    private void Start()
    {
    }

    private void Update()
    {
    }

    public void AddItem(int itemID, Player player)
    {
        foreach (var item in itemDatabase)
            if (item.id == itemID)
            {
                Debug.Log("You a have match");
                player.inventory[itemID] = item;
                return;
            }

        Debug.Log("Item does not exist!");
    }

    public void RemoveItem(int itemID, Player player)
    {
        foreach (var item in itemDatabase)
            if (item.id == itemID)
            {
                Debug.Log("Ids match: " + item.id + " " + itemID);
                player.inventory[itemID] = null;
                return;
            }

        Debug.Log("Item does not exist!");
    }

    public void ListItems()
    {
        foreach (var item in itemDatabase)
            Debug.Log("ID: " + item.id + " Name: " + item.name + " Description: " + item.description);
    }
}