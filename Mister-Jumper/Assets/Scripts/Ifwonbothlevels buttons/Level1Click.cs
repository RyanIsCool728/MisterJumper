using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Click : MonoBehaviour
{
    public void level1buttonclick()
    {
        PlayerPrefs.SetString("LevelName", "Level1");
        PlayerPrefs.Save();
        SceneManager.LoadScene("Level1");
    }
}
