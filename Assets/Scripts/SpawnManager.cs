using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<Wave> _waves = new List<Wave>();
    private int _currentWave;
    void Start()
    {
        StartCoroutine(StartWaveRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartWaveRoutine()
    {
        while (true)
        {
            var currentWave = _waves[this._currentWave].sequence;
            var container = new GameObject("PreviousWave");
            foreach (var obj in currentWave)
            {
                Instantiate(obj, container.transform);
                yield return new WaitForSeconds(1.0f); 
            }
            yield return new WaitForSeconds(5.0f); 
            Destroy(container);
            _currentWave++;
            if (_currentWave == _waves.Count)
            {
                Debug.Log("Finished Waves");
                break;
            }
        }
    }
}
