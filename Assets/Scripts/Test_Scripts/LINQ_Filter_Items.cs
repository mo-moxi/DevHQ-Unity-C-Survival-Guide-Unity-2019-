using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items
{
    public string name;

    public int itemID;

    public int buff;
}

public class LINQ_Filter_Items : MonoBehaviour
{
    public List<Items> itemsList;
    // Start is called before the first frame update
    void Start()
    {
        var namesFound = itemsList.Contains("3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
