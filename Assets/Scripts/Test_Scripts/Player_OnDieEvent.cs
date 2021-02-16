using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_OnDieEvent : MonoBehaviour
{
    public delegate void DeathCount();

    public static event DeathCount deathCount;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }
    void Death()
    {
        if(deathCount !=null)
        {
            deathCount();
        }
    }
}
