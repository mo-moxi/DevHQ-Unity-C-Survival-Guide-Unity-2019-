using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{
    public static string company = "Work-to-the-bone";
    public string employeeName;
    
    public abstract void CalculateMonthlySalary();
    
}
