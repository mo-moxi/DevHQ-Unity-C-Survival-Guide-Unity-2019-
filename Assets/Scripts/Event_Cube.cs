using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Event_Cube : MonoBehaviour
{
    private MeshRenderer _mesh;
    // Start is called before the first frame update
    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
        Events_1.onClick += ChangeColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        _mesh.material.color = Color.red;
    }
}
