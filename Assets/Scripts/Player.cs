using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public Item[] inventory = new Item[10];

    private ItemDB itemDatabase;

    private void Start()
    {
        itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
        itemDatabase.ListItems();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            itemDatabase.AddItem(1, this);
        else if (Input.GetKeyDown(KeyCode.R)) itemDatabase.RemoveItem(20, this);
    }
}