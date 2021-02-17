using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Player_Actions : MonoBehaviour
{
    // traditional delegate (version 2)
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;

    // Version 3 and above use Action
    
    public static Action<int> OnDamagedReceived;   
    public int Health { get; set; }

    void Start()
    {
        Health = 100;
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
}
