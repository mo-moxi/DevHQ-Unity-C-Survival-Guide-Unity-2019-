using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Books
{
    public string title;
    public string author;
    public int id;
    
    public enum Genre
    {
        Fantasy,
        Crime,
        Comedy,
        Thriller,
        Adventure,
        Romance
    }
}

public class Main_Primitive_Type : MonoBehaviour
{
    public Dictionary<string, int> people = new Dictionary<string, int>();
    public Dictionary<int, string> Books = new Dictionary<int, string>();

    public List<Books> books = new List<Books>(); // vales assign in the inspector
    
    void Start()
    {
        people.Add("Jon", 26);
        people.Add("Jonney", 36);
        people.Add("Jane", 12);
        people.Add("Joel", 19);

        int age = people["Jon"];
        Debug.Log("Jon's Age: " + age);
        
        Books.Add(0, "The Hitchhiker's Guide to the Galaxy");               // assign data to Books
        Books.Add(1, "The Restaurant at the end of the Universe");
        Books.Add(2, "So Long, and Thanks for All the Fish");
        Books.Add(3, "The Long Dark Tea-time of the Soul");
        Books.Add(4, "Douglas Adam's Starship Titanic");
        Books.Add(5, "Dirk Gently's Holistic Detective Agency");

        for (int i = 0; i < Books.Count; i++)
        {
            Debug.Log("Book " + i + " is " + Books[i]);
        }

        foreach (KeyValuePair<int, string> book in Books)
        {
            Debug.Log("Book " + book.Value + " is number " + book.Key); // print value and key
        }
        foreach (string book in Books.Values) // print jus the value
        {
            Debug.Log("Book " + book);
        }
        foreach (var key in Books.Keys) // print jus the keys
        {
            Debug.Log("Book key is " + key);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
