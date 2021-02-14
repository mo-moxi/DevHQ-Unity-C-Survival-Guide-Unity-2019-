using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public enum Difficulty
    {
        East,
        Normal,
        Hard,
        Expert
    }

    public Difficulty selectDifficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)selectDifficulty);
    }
}
