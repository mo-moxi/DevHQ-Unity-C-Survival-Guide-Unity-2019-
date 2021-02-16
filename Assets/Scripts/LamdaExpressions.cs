using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamdaExpressions : MonoBehaviour
{
    // create a program that takes a string and return its length –how many characters
    // public delegate int CharacterLength(string test);

    // void delegate use Action and return delegates use Func
    public Func<string, int> CharacterLength; // return type delegate
    public Action<int, int> Sum;              // void type delegate
    public Action onGetName;                  // void no parameters delegate
    public Func<int> onGetName1;              // Func return int
    
     void Start()
     {
         //show character length using a Func and lamda expression
         CharacterLength = (name) => name.Length;
         int count = CharacterLength("Manifesto");
         Debug.Log("Count: " + count);
         
         // calculate the sum of two number using Action and lamda
         Sum = (a, b) =>
         {
             var total = a + b;
              Debug.Log("Total:" + total);
         };
         Sum(8, 3);
         Sum(5, 5);
         
         // traditional dedicated method
        CalculateSum(9, 2);
        
        // Void type delegate
        onGetName = () => Debug.Log("Name: " + gameObject.name);
        onGetName();
        
        // Func int with void
        onGetName1 = () => this.gameObject.name.Length;
        int charactrerCount = onGetName1();
        Debug.Log("Character Count: " + charactrerCount);
     }

     void CalculateSum(int a, int b)
     {
         var total = a + b;
         Debug.Log("Traditional total:" + total);
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
