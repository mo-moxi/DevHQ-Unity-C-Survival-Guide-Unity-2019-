using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The GameManger is NUll."); 
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
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
