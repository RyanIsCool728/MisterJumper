using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class PlayScore : MonoBehaviour
{
    public Transform player;
    public TMPro.TextMeshProUGUI Score;
    // Update is called once per frame
    void Update()
    {
            string scoreText = "Score: " + player.transform.position.x.ToString("0");
            Score.text = scoreText;
            ScoreController.score = player.transform.position.x;
            float scoresave = player.transform.position.x;
            PlayerPrefs.SetFloat("Score", scoresave);
            PlayerPrefs.Save();
    }
}
