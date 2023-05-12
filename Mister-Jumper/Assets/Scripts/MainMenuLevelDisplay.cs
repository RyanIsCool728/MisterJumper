using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuLevelDisplay : MonoBehaviour
{
    public TMPro.TextMeshProUGUI LevelDisplay;
    private void Update()
    {
        int LevelNumber = PlayerPrefs.GetInt("LevelFinished");
        if (LevelNumber == 1)
        {
            LevelDisplay.text = "Level Completed: " + LevelNumber;
        }
        else if (LevelNumber == 2)
        {
            LevelDisplay.text = "Levels Completed: " + LevelNumber;
        }
        else if (LevelNumber == 0)
        {
            LevelDisplay.text = "You have not beaten any of the levels yet!";
        }
       


    }
}
