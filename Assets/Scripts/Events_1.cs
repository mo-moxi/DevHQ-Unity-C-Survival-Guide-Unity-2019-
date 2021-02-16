using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events_1 : MonoBehaviour
{
    public delegate void ActionClick();

    public static event ActionClick onClick;
    
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
        
    }
}
