using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events_1 : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

//    private delegate void Teleport(Vector3 pos);
//    public static event Teleport onTeleport;

    public static Action<Vector3> onTeleport;
    
    public void ButtonClick()
    {
        // turn all cubes green
        if(onClick !=null)
            onClick();
    }

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            //onTeleport(new Vector3(5, 2, 0));
            //or
            Vector3 pos = new Vector3(5,2,0);
            onTeleport(pos);
            // GDHQ prefer second 'pos' option 
        }
        
    }
}
