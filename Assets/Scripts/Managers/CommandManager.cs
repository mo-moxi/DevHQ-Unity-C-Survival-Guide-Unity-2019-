using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;

    public static CommandManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Command Manger is NULL.");
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }

    private List<ICommand> _commandBuffer = new List<ICommand>();

    public void AddCommand(ICommand command)
    {
        _commandBuffer.Add(command);
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void Play()
    {
        Debug.Log("Play Button");
        StartCoroutine(PlayRoutine());
    }

    public void Rewind()
    {
        StartCoroutine(RewindRountine());
    }

    IEnumerator PlayRoutine()
    {
        foreach (var command in _commandBuffer)
        {
            Debug.Log("Playing...");
            command.Execute();
            yield return new WaitForSeconds(1.0f);
        }
    }

    IEnumerator RewindRountine()
    {
        Debug.Log("Rewinding...");
        foreach (var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undue();
            yield return new WaitForSeconds(1.0f);
        }
    }

    public void Done()
    {
        var cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    public void Reset()
    {
        _commandBuffer.Clear();
    }
}
