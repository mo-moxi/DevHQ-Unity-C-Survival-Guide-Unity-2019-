using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_OnDieEvent : MonoBehaviour
{
    public int deathCount;
    public Text deathCountText;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Player_OnDieEvent.deathCount += UpdateDeathCount;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count: " + deathCount;
    }
}
