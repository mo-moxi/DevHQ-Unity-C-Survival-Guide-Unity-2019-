using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{
    public int health { get; set; }
    public void Damage(int damageAmount)
    {
        throw new System.NotImplementedException();
    }
}
