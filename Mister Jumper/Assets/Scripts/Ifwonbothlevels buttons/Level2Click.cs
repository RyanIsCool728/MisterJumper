using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Click : MonoBehaviour
{
    public void level2buttonclick()
    {
        PlayerPrefs.SetString("LevelName", "Level2");
        PlayerPrefs.Save();
        SceneManager.LoadScene("Level2");
    }
}
