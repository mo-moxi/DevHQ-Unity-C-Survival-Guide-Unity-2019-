using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public LevelSelector currentLevel;

    private void Start()
    {
        if (currentLevel == LevelSelector.Easy)
            Debug.Log("You selected: Easy");
        if (currentLevel == LevelSelector.Normal)
            Debug.Log("You selected: Normal");
        if (currentLevel == LevelSelector.Hard)
            Debug.Log("You selected: Hard");
        if (currentLevel == LevelSelector.Expert)
            Debug.Log("You selected: Expert");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            switch (currentLevel)
            {
                case LevelSelector.Easy:
                    Debug.Log("Easy!");
                    break;
                case LevelSelector.Normal:
                    Debug.Log("Normal!");
                    break;
                case LevelSelector.Hard:
                    Debug.Log("Hard!");
                    break;
                case LevelSelector.Expert:
                    Debug.Log("Expert!");
                    break;
            }
    }
}