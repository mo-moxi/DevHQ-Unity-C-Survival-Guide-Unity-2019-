using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Events_1.onClick += Fall;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
