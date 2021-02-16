using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable // use <float> <int> , etc for generic types
{
    private MeshRenderer _mesh;
    public int health { get; set; }
    public void Damage(int damageAmount)
    {
        _mesh.material.color = Color.cyan;
    }
    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
        Main.onClick += ChangeColor;                        // onClick is a trigger for methods with similar parameters
        Main.onClick += Move;
    }

    public void ChangeColor() // method signature must match method in main
    {
        _mesh.material.color = Color.blue;
    }
    public void Move()
    {
        transform.position = new Vector3(-2f, 1f, -1f);
    }

    private void OnDisable()
    {
        Main.onClick -= ChangeColor;
        Main.onClick -= Move;
    }
}
// the below is used in abstract classes
/*public abstract class Enemy : MonoBehaviour
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
*/    

