using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_Actions : MonoBehaviour
{
    public Text healthText;
    public void OnEnable()
    {
        Player_Actions.OnDamagedReceived += UpDateHealth;
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
