using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_1 : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);

    public ChangeColor onColorChange;

    public delegate void OnComplete();

    public OnComplete onComplete;
    
    void Start()
    {
        onColorChange = UpdateColor;                // signature must match method
        onColorChange(Color.red);                   // to invoke onColorChange
        onComplete += Task;                         // signature must match method
        onComplete += Task;                         // multi delegate use +=. To remove a delegate task -=
        onComplete();                               // to invoke onComplete    
    }                                               // note: the delegate can call any method with similar signature    

    public void UpdateColor(Color newColor)
    {
        Debug.Log("The colour was changed to..." + newColor.ToString());
    }

    public void Task()
    {
Debug.Log("Task Complete");        
    }
    
    // multicast
    
    public void Task2()
    {
        Debug.Log("This is a multitask delegate result.");        
    }
}
