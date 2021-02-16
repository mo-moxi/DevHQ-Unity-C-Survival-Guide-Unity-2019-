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
        // this line filters by size, puts in orderby/descending order and then reverses the order
        var passingGrade = grades.Where(pg => pg > 69).OrderBy(g => g);//.Reverse();
        foreach (var item in passingGrade)
        {
            Debug.Log("Grade result: " + item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
