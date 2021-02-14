using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player
{
    public string name;
    public int id;

    public Player(int id)
    {
        this.id = id;
    }
    
}

public class Main : MonoBehaviour
{
    private Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();

    private Player p3;
    void Start()
    {
        Player p1 = new Player(1);
        p1.name = "Mike";
        Player p2 = new Player(200);
        p2.name = "Mu";
        p3 = new Player(13);
        p3.name = "Minty";
        
        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[200];
            Debug.Log("Player " + player.name);
            
            var player3 = playerDictionary[p3.id];
            Debug.Log("Player " + player3.name);
        }
    }
}
