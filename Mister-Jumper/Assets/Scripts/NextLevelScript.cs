using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{

    public void NextLevel()
    {
        string LevelNumber = PlayerPrefs.GetString("LevelName");
        if (LevelNumber == "Level1")
        {
            SceneManager.LoadScene("Level2");
            PlayerPrefs.SetString("LevelName", "Level2");
            PlayerPrefs.Save();
        }

       
    }
}
