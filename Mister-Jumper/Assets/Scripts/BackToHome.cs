using UnityEngine.SceneManagement;
using UnityEngine;

public class BackToHome : MonoBehaviour
{
    public void BTH()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
