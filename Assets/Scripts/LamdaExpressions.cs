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
    
     void Start()
     {
         CharacterLength = (name) => name.Length;
         int count = CharacterLength("Manifesto");
         Debug.Log("Count: " + count);
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
