using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_Events_Example : MonoBehaviour
{
    public delegate void ActionClick();

    public static event ActionClick onClick;
    
    public void ButtonClick()
    {
        Debug.Log("Button");
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
