﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Hide", 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
    
}
