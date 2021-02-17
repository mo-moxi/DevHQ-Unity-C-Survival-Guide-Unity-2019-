using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
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
