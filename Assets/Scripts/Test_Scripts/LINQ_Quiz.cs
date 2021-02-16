using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQ_Quiz : MonoBehaviour
{
    public int[] grades = {37, 55, 94, 78, 43, 77, 90, 80, 69, 83};
    // Start is called before the first frame update
    void Start()
    {
        var GradeResult = grades.Where(n => n > 69);
        foreach (var item in GradeResult)
        {
            Debug.Log("Name result: " + item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
