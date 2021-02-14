using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Challenge: Create an array of three game object and randomly
    // spawn them between +/-10 on x/y when space key is pressed.
    // limit spawn to ten then turn spawned object green before 
    // clearing the list.
    [SerializeField] private List<GameObject> itemsToSpawn = new List<GameObject>();
    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // spawn objects
            // increment counter to 10
            // on eleven turn them green
            // on 12 clear the list
        }
    }
}
