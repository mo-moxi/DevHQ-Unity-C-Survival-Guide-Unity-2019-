using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Enemy : MonoBehaviour, IDamagable

{
    public int health { get; set; }
    public void Damage(int damageAmount)
    {
        throw new System.NotImplementedException();
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

