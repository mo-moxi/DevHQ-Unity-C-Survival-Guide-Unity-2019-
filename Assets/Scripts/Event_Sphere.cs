using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Events_1.onClick += Fall;
        Events_1.onTeleport += Teleport;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    public void Teleport(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        Events_1.onTeleport -= Teleport;
    }
}
