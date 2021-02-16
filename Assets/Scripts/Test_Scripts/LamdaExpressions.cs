using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamdaExpressions : MonoBehaviour
{
    // create a program that takes a string and return its length –how many characters
    // public delegate int CharacterLength(string test);

    // void delegate use Action and return delegates use Func
    public Func<string, int> CharacterLength;
    public Action<int, int> Sum1;
    public Action<int, int> Sum2;

     void Start()
     {
         CharacterLength = (name) => name.Length;
         int count = CharacterLength("Manifesto");
         Debug.Log("Count: " + count);
         
         Sum2(5, 3);
         Sum2 = (a, b) =>
         {
             var total = a + b;
             if (total < 100)
             {
                 Debug.Log("Failed: looser!");
             }
             Debug.Log("Total: " + total);
         };
         
         // for sum below
         Sum1(5, 5);
         Sum1 = CalculateSum;
     }
     void CalculateSum(int a, int b)
     {
         var total = a + b;
         Debug.Log("Action return sum " + total);
     }
/*     int getCharacters(string name)       // replaced by lamda above
     {
         return name.Length;
     }
*/
     // Update is called once per frame
    void Update()
    {
        
    }

}
