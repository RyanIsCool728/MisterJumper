using UnityEngine.SceneManagement;
using UnityEngine;

public class OnPlayerCollisions : MonoBehaviour
{
    public int Levelcompleted = 0;

    private void Start()
    {
        // Load the value of "LevelFinished" from PlayerPrefs and assign it to Levelcompleted
        Levelcompleted = PlayerPrefs.GetInt("LevelFinished", 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene("YouDied");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ENDLv1")
        {
            if (Levelcompleted == 0)
            {
                Levelcompleted = 1;
                PlayerPrefs.SetInt("LevelFinished", Levelcompleted);
                PlayerPrefs.Save();
                SceneManager.LoadScene("YouWon");
            }
            else if (Levelcompleted == 2)
            {
                SceneManager.LoadScene("YouWonIfFinished");
            }
        }
        if (collision.tag == "ENDLv2")
        {
            string LevelVar = PlayerPrefs.GetString("LevelName");
            if (Levelcompleted == 1)
            {
                Levelcompleted = 2;
                PlayerPrefs.SetInt("LevelFinished", Levelcompleted);
                PlayerPrefs.Save();
                SceneManager.LoadScene("YouWonIfFinished");
            }
            else
            {
                SceneManager.LoadScene("YouWonIfFinished");
            }
        }
    }
}
