using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public abstract class Enemy : MonoBehaviour
{
    public int speed;
    public int health;
    public int gems;
    
    private void Start()
    {
        
    }
    
    private void Update()
    {
        
    }
    public abstract void Attack();
}

