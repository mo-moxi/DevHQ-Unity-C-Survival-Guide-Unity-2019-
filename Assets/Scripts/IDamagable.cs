using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable // add <T> for generic types
{
    int health { get; set; }
    
    void Damage(int damageAmount); // use Damage(T damageAmount) fro generic types
    
}
