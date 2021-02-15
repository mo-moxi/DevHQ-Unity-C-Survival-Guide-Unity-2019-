using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable // use <float> <int> , etc for generic types
{
    public int health { get; set; }
    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
