using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player_OnDieEvent.deathCount += ResetPlayer;
    }

    void Start()
    {

    }
    
    void Update()
    {
        
    }

    public void ResetPlayer()
    {
        Debug.Log("Resetting Player");
        // why is this printing twice?
    }
}
