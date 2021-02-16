using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LINQExample : MonoBehaviour
{
    public string[] names = {"jon", "gillian", "jon", "simon", "gillian", "Wu"};
    // Start is called before the first frame update
    void Start()
    {
    /*  // traditional method
        foreach (var item in names)
        {       if(item == "simon")
                Debug.Log("Name exists: " + name);}
    */
    // var namesFound = names.Any(name => name == "simon");
    var namesFound = names.Contains("gillian");
    Debug.Log("Does name exist:" + namesFound);
    var uniqueNames = names.Distinct();
    foreach (var item in uniqueNames)
    {
        Debug.Log("Name: " + item);
    }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
