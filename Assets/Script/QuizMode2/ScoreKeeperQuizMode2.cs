using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeperQuizMode2 : MonoBehaviour
{
    public static ScoreKeeperQuizMode2 instance;

    public int scoreQuizMode2;

    public int batasMenang;

    public Text scoreQuizMode2Text;
    public Text score;

    public int abc;

    GameManagerAgain gma;
    GameManagerTutorial gmt;


    void Awake()
    {
        gma = FindObjectOfType<GameManagerAgain>();
        gmt = FindObjectOfType<GameManagerTutorial>();

        instance = this;
    }

    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Fact"))
        {
                gma.EndScreen.gameObject.SetActive(false);
        }
            
    }

    
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Fact"))
        {
            if (scoreQuizMode2 == batasMenang)
            {
                gmt.PanelQuiz.gameObject.SetActive(false);
                gma.EndScreen.gameObject.SetActive(true);
            }
           scoreQuizMode2Text.text = scoreQuizMode2.ToString();
        }
        score.text = scoreQuizMode2.ToString();
            
    }

    public void IncrementScore()
    {
        scoreQuizMode2 += 10;
        Debug.Log(scoreQuizMode2);
    }

    public int CalculateScore()
    {
        abc = scoreQuizMode2;
        return abc;
    }
}
