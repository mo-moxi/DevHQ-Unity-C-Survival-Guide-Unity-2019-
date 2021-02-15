using System;
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
    public Camera cam;
    private Attendee p3;
    public string letters;
    
    // Delegates//
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onChangeColor;
    public delegate void OnComplete(); // func...
    public OnComplete onComplete;

    public delegate string OnCompleted(); // func...
    public OnComplete onCompleted;

    public delegate void ActionClick();
    public static event ActionClick onClick;

    public Func<string, int> WordLength;

    int LetterCount(string letters)
    {
        return letters.Length;
    }

    public delegate int CharacterLength(string text); // linked to below ****

    int GetCharacters(string name)
    {
        return name.Length;
    }
    
    // end of delegates

    private string SomethingToDo()
    {
        // this is linked to the delegate string above
        return null; // don't know what this should be 
    }
    void Start()
    {
        WordLength = LetterCount;
        int count = WordLength("Manifesto");
        Debug.Log("Func Word Length: " + count);
        
        CharacterLength cl = new CharacterLength(GetCharacters); // return types ****
        //code
        //code
        Debug.Log(cl("Delegate return type word length for Hobo"));
        
        Attendee p1 = new Attendee(1);
        p1.name = "Mike";
        Attendee p2 = new Attendee(200);
        p2.name = "Mu";
        p3 = new Attendee(13);
        p3.name = "Minty";
        
        AttendeeDictionary.Add(p1.id, p1);
        AttendeeDictionary.Add(p2.id, p2);
        AttendeeDictionary.Add(p3.id, p3);
        
        // delegates
        onChangeColor = UpDateColor;
        onChangeColor(Color.green);
        onComplete += Task;     // += register =+ de-register
        onComplete += Task2;
        onComplete += Task3;
        if(onComplete !=null)
            onComplete();
        // delegates
        string name = "Delegate string return type word length for Hobo";
        int characterCount = GetCharacters(name);
        Debug.Log("Character Length: " + characterCount);


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

        if (Input.GetMouseButtonDown(0))

        {
            Ray rayOrigin = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                IDamagable obj = hitInfo.collider.GetComponent<IDamagable>();
                if(obj !=null)
                    obj.Damage(5);
            }
        }
    }

    // delegates
    public void UpDateColor(Color newColor)
    {
        Debug.Log("Changing colour to " + newColor.ToString());
    }
    public void Task()
    {
        Debug.Log("Task Finished");
    }
    public void Task2()
    {
        Debug.Log("Task 2 Finished");
    }
    public void Task3()
    {
        Debug.Log("Task 3 Finished");
    }
    public void SalmonFishingInYemen(Color salmon)
    {
        
    }
    //UI button  click
    public void onButtonClick()
    {
        if (onClick !=null)
            onClick();
    }
}
