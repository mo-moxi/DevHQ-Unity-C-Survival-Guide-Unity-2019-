using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_Actions : MonoBehaviour
{
    public Text healthText;
    public void OnEnable()
    {
        // Standard static Action 
        // Player_Actions.OnDamagedReceived += UpDateHealth;
        // Subscription to static instance (singleton) class delegate
        Player_Actions.Instance.OnDamagedReceived += UpDateHealth;
    }

    public void UpDateHealth(int health)
    {
        healthText.text = "Health: " + health;
        // display updated health
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
