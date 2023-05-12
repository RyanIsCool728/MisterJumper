using UnityEngine.SceneManagement;
using UnityEngine;

public class ReplayScene : MonoBehaviour
{
    public void Replay()
    {
        string SceneVar = PlayerPrefs.GetString("LevelName");
        SceneManager.LoadScene(SceneVar); 
    }
}
