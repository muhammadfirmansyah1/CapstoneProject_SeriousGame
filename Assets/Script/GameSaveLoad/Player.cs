using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text hasilloadQuiz;

    public int scoreQuiz;
    public int test;

    // int scoreQuizMode2;

    public float coba;
    public Text cobaText;


   ScoreKeeper scoreKeeper;
   ScoreKeeperQuizMode2 scoreKeeperQuizMode2;
    MainMenu mainmenu;
   Player player;
   Quiz quiz;

    void Awake()
    {
       scoreKeeper = FindObjectOfType<ScoreKeeper>();
       scoreKeeperQuizMode2 = FindObjectOfType<ScoreKeeperQuizMode2>();
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Fact"))
        {
            scoreQuiz = scoreKeeperQuizMode2.CalculateScore();
            test = scoreQuiz;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Pilgan-1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Pilgan-2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Pilgan-3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Nasihat"))
        {
            scoreQuiz = scoreKeeper.CalculateScore();
            test = scoreQuiz;
        }
            
        
      
    }


    public void SaveCoba()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        int scoreQuiz1 = data.scoreQuiz;
        if(test >= scoreQuiz1)
        {
            SaveSystem.SavePlayer(this);
        }
    }

    public void ResetSaveLoad()
    {
        scoreQuiz = 0;
        SaveSystem.SavePlayer(this);
        SceneManager.LoadScene("Chapters");
    }

    public void LoadCoba()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        scoreQuiz = data.scoreQuiz;
        cobaText.text = scoreQuiz.ToString();
    }


    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        PlayerPrefs.SetFloat("Score_Quiz",scoreQuiz);
    }

    public void LoadPlayer()
    {
         PlayerData data = SaveSystem.LoadPlayer();
         scoreQuiz = data.scoreQuiz;
         hasilloadQuiz.text = scoreQuiz.ToString();
    }

    public void SavePlayerPref()
    { 
    }

    public void LoadPlayerPref()
    {
       hasilloadQuiz.text = PlayerPrefs.GetFloat("scoreQuizChapter").ToString();
    }




    
}

