using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The UIManager is NUll."); 
            return _instance;
        }
    }

    private void OnAwake()
    {
        _instance = this;
    }

    public void OnEnable()
    {
        Player.onDamageReceived += UpdateHealth;
    }
    public void UpdateHealth(int health)
    {
        Debug.Log("Updating health");
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
