using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonClicked : MonoBehaviour
{
    public void onclick()
    {

        int LevelNumber = PlayerPrefs.GetInt("LevelFinished");
        if (LevelNumber == 0)
        {
            PlayerPrefs.SetString("LevelName", "Level1");
            PlayerPrefs.Save();
            string LevelNamevar = PlayerPrefs.GetString("LevelName");
            SceneManager.LoadScene("Level1");
        }
        if (LevelNumber == 1)
        {
            PlayerPrefs.SetString("LevelName", "Level2");
            PlayerPrefs.Save();
            string LevelNamevar = PlayerPrefs.GetString("LevelName");
            SceneManager.LoadScene("Level2");
        }
           
        if (LevelNumber == 2)
        {
            PlayerPrefs.SetString("LevelName", "Ifwonbothlevels");
            PlayerPrefs.Save();
            string LevelNamevar = PlayerPrefs.GetString("LevelName");
            SceneManager.LoadScene("Ifwonbothlevels");
        }


        
    }
}

