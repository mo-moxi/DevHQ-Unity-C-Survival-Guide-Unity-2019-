using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Challenge: Create an array of three game object and randomly
    // spawn them between +/-10 on x/y when space key is pressed.
    // limit spawn to ten then turn spawned object green before 
    // clearing the list.
    [SerializeField]
    private List<GameObject> _itemsToSpawn = new List<GameObject>(); // create item list
    private List<GameObject> _spawnedItem = new List<GameObject>();  // create spawn reference list 
    private int _spawnCount;
    [SerializeField]
    private int _spawnLimit = 10;
    [SerializeField]
    private float _spawnRange  = 10f;

    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _spawnCount ++;
            if(_spawnCount < (_spawnLimit +1))
            {
                SpawnItem(Random.Range(0, _itemsToSpawn.Count));
            }
            else if (_spawnCount == (_spawnLimit +1))
            {
                ChangeColor();
            }
            else
            {
                ClearList();
            }
        }
    }
    private void SpawnItem(int item)
    {
        var xSpawn = Random.Range(0, _spawnRange);   // random x
        var ySpawn = Random.Range(0, _spawnRange);   // random y
        var pos = new Vector3(xSpawn, ySpawn, 0f);     //  set position 
        _spawnedItem.Add(Instantiate(_itemsToSpawn[item], pos, Quaternion.identity)); // spawn item and get item reference
    }

    private void ChangeColor()
    {
        foreach (var item in _spawnedItem)
        {
            item.GetComponent<MeshRenderer>().material.color = Color.green; // change item color
        }
    }

    private void ClearList()
    {
        foreach (var item in _spawnedItem)
        {
            item.SetActive(false); // de-activate item
        }
    }
}
