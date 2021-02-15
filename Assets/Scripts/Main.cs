using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Attendee
{
    public string name;
    public int id;

    public Attendee(int id)
    {
        this.id = id;
    }
    
}

public class Main : MonoBehaviour
{
    private Dictionary<int, Attendee> AttendeeDictionary = new Dictionary<int, Attendee>();

    private Attendee p3;
    void Start()
    {
        Attendee p1 = new Attendee(1);
        p1.name = "Mike";
        Attendee p2 = new Attendee(200);
        p2.name = "Mu";
        p3 = new Attendee(13);
        p3.name = "Minty";
        
        AttendeeDictionary.Add(p1.id, p1);
        AttendeeDictionary.Add(p2.id, p2);
        AttendeeDictionary.Add(p3.id, p3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var Attendee = AttendeeDictionary[200];
            Debug.Log("Attendee " + Attendee.name);
            
            var Attendee3 = AttendeeDictionary[p3.id];
            Debug.Log("Attendee " + Attendee3.name);
        }
    }
}
