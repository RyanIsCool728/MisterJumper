using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DiedDisplayScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI ScoreText;
    public TMPro.TextMeshProUGUI Scoresavetext;


    private void Start()
    {
        // display the score
        ScoreText.text = "Score: " + ScoreController.score.ToString("0");


    }
}
