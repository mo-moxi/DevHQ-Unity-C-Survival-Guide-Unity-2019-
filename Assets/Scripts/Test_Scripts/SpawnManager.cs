using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoSingleton<SpawnManager>
{
    public int hello = 12;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Player_Actions.Instance.lopp);
        Init();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Init()
    {
        Debug.Log("SpawnManger Started");
    }

}
