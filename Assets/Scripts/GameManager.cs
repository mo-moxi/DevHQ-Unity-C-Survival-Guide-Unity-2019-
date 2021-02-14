 // using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<string> names = new List<string>();
    private void Start()
    {
        PrintNames();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var i = Random.Range(0, names.Count);
            if (names.Count > 0)
            {
                RemoveName(i);
                PrintNames();
            }
        }
    }
    private void PrintNames()
    {
        foreach (var item in names)
        {
            Debug.Log("Name: " + item);
        }
    }
    private void RemoveName(int i)
    {
        Debug.Log("We removed: " + names[i]);
        names.Remove(names[i]);
    }
}
