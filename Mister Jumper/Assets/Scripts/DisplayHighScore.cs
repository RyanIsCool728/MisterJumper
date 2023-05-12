using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DisplayHighScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Scoresavetext;
    public void Start()
    {
        float score = PlayerPrefs.GetFloat("Score");
        Scoresavetext.text = "Most Recent Score: " + score.ToString("0");


    }
}
        