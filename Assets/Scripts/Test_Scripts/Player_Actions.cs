using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Player_Actions : MonoSingleton<Player_Actions>
{
    // traditional delegate (version 2)
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;

    // Version 3 and above use Action
    public int lopp = 13;
    public Action<int> OnDamagedReceived;   
    public int Health { get; set; }

    void Start()
    {
        Health = 100;
        var hello = SpawnManager.Instance.hello;
        Debug.Log(hello);
        
    } 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage();
        }
            
    }

    public void Damage()
    {
        Health--;
        if (OnDamagedReceived != null)
            OnDamagedReceived(Health);
    }

    public override void Init()
    {
        base.Init();
        Debug.Log("Player started");
    }
}
