using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Enemy : MonoBehaviour, IDamagable // use <float> <int> , etc for generic types
{
    public int health { get; set; }
    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
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

