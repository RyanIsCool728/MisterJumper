using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevelComplete : MonoBehaviour
{ 
    public TMPro.TextMeshProUGUI LevelDisplay;
    public void Update()
    {
       
        int LevelNumber = PlayerPrefs.GetInt("LevelFinished");
        
        LevelDisplay.text = "Levels Completed: " + LevelNumber;



    }
}
