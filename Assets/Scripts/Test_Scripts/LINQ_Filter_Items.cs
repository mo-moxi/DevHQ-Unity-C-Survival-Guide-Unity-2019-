using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Items
{
    public string name;

    public int itemID;

    public int buff;
}

public class LINQ_Filter_Items : MonoBehaviour
{
    public List<Items> items;
    // Start is called before the first frame update
    void Start()
    {
      var result = items.Any(items => items.itemID == 3);
      Debug.Log("Result:" + result);

      var buffResult = items.Where(items => items.buff > 20);
      foreach (var item in buffResult)
      {
          Debug.Log("Name Result:" + item.name);
      }

      var buffAvg = items.Average(item => item.buff);
      Debug.Log("Buff avg:" + buffAvg);
      


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
