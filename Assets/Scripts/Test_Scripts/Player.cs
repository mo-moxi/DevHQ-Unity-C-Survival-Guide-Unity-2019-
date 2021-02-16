using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable // use <float> <int> , etc for generic types
{
    // delegates
    // public delegate void OnDamagedReceived(int currentHealth);
    // public static event OnDamagedReceived onDamage;

    public static Action<int> onDamageReceived; // this is the same code as above
    
    private MeshRenderer _mesh;
    public int health { get; set; }
    public void Damage(int damageAmount)
    {
        _mesh.material.color = Color.red;
    }
    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
        Main.onClick += ChangeColor;                        // onClick is a trigger for methods with similar parameters
        Main.onClick += Move;
    }

    public void ChangeColor() // method signature must match method in main
    {
        _mesh.material.color = Color.green;
    }
    public void Move()
    {
        transform.position = new Vector3(2f, 2f, 2f);
    }

    private void OnDisable()
    {
        Main.onClick -= ChangeColor;
        Main.onClick -= Move;
    }
}
