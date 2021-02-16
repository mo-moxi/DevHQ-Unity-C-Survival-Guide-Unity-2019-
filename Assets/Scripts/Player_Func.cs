using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_Func : MonoBehaviour
{
    //tradition return type delegate
    // public delegate int CharacterLength(string text);
    // private CharacterLength cl;
    // Start is called before the first frame update

    public Func<string, int> CharacterLength;
    void Start()
    {
        // traditional function
        // string name = "Mostoks";
        // int length = GetCharacters(name);
        // Debug.Log("Name length: " + length);
        
        // return type delegate and function
        //cl = GetCharacters;
        //code
        //code
        // Debug.Log(cl("Mostoks"));
        
        // Func or return type delegate 
        CharacterLength += GetCharacters;
        int count = CharacterLength("Museli");
        Debug.Log("Count:" + count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetCharacters(string text)
    {
        return name.Length;
    }
}
