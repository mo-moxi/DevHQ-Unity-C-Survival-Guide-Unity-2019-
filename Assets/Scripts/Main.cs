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
    
    // Delegates//
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onChangeColor;
    public delegate void OnComplete();
    public OnComplete onComplete;

    public delegate void ActionClick();
    public static event ActionClick onClick;
    
    // end of delegates
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
        
        // delegates
        onChangeColor = UpDateColor;
        onChangeColor(Color.green);
        onComplete += Task;     // += register =+ de-register
        onComplete += Task2;
        onComplete += Task3;
        if(onComplete !=null)
            onComplete();
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
