using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj1 : MonoSingleton<Obj1>
{
    void Start()
    {
        Debug.Log(Obj.Instance.objPrize);
        Init();
        Obj.Instance.Init();
    }

    public override void Init()
    {
        base.Init();
        Debug.Log("Obj1 started");
    }
}
