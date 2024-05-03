using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreScript : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    public static int scoreCount;
    public static int highScoreCount;
    public GameObject levelSystem;
    levelSystem levelScript;



    void Start()
    {
        if (PlayerPrefs.HasKey ("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetInt("HighScore");
        }

        levelScript = levelSystem.GetComponent<levelSystem>();
    }


    void Update()
    {
        updateScore();
        updateScoreText();

    }

    public void updateScoreText()
    {
        scoreText.text = "Score: " + scoreCount;
        highScoreText.text = "Hi-score " + highScoreCount;
    }

    public void updateScore()
    {
        if(scoreCount > highScoreCount)
        {
        highScoreCount = scoreCount;
        PlayerPrefs.SetInt("HighScore", highScoreCount);
        }

        scoreCount = levelScript.currentLevel - 1;

    } 


}


