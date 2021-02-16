using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LINQExample : MonoBehaviour
{
    public string[] names = {"jon", "gillian", "simon"};
    // Start is called before the first frame update
    void Start()
    {
    /*    foreach (var item in names)
        {
            if(item == "simon")
                Debug.Log("Name exists: " + name);
        }
    */
    var namesFound = names.Any(name => name == "simon");
    Debug.Log("Does name exist:" + namesFound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
