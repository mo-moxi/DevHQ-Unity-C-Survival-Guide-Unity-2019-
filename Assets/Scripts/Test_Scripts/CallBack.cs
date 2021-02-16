using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyRoutine(() =>
        {
            Debug.Log("Shit happens!");
        }));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(5.0f);

        if (onComplete != null)
            onComplete();
    }
}
