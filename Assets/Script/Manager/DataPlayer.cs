using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPlayer : MonoBehaviour
{
    public Text ScoreBox;
    public Text ScoreDungeon;
    public Text ScoreQuiz;

    HighScore HighScoreQuiz;
    HighScoreBox HighScoreBox;

    ScoreKeeper scoreKeeper;

    Player player;

    void Start()
    {
        HighScoreQuiz = FindObjectOfType<HighScore>();
        HighScoreBox = FindObjectOfType<HighScoreBox>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreBox.text = "Skor Balok Tertinggi saat ini : " + PlayerPrefs.GetInt("HighScoreBox").ToString();
       // ScoreQuiz.text = "Skor Quiz Tertinggi saat ini  : " + PlayerPrefs.GetInt("HighScore").ToString();

       // player.LoadPlayer();
        ScoreQuiz.text = "Skor Quiz Tertinggi saat ini  : " + scoreKeeper.CalculateScore();
    }

    void LoadDataQuiz()
    {
       // player.LoadPlayer();
    }
}
