using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoSingleton<Obj>
{
    public int objPrize = 14;

    public override void Init()
    {
        base.Init();
        Debug.Log("Obj started");
    }
}

