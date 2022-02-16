using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score;

    public int highScore;

    public Text scoreText, highScoreText;
    

    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");

            highScoreText.text = highScore.ToString();
        }

        


    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    public void AddScore()
    {
        score++;
        updateHighScore();

        scoreText.text = score.ToString();
        

    }

    public void updateHighScore()
    {
        if(score > highScore)
        {
            highScore = score;

            highScoreText.text = highScore.ToString();

            PlayerPrefs.SetInt("HighScore", highScore);
        }

    }

    public void resetScore()
    {
        score = 0;
    }

    public void deleteHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }

    }  
