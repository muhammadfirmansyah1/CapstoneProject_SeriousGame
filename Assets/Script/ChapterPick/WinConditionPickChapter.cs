using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinConditionPickChapter : MonoBehaviour
{
    public static WinConditionPickChapter instance;

    [Header("Load Score")]
    public int scoreQuiz;
    //public int scoreQuizMode2;
    public Text scoreQuizText;

    [Header("Batas Minimal Score Tiap Chapter")]
    [SerializeField] public int scoreBond_1 = 40;
    [SerializeField] public int scoreBond_2 = 50;
    [SerializeField] public int scoreBond_3 = 60;
    [SerializeField] public int scoreBond_4 = 70;
    [SerializeField] public int scoreBond_5 = 80;

   

    Player player;
    void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        scoreQuiz = data.scoreQuiz;
        scoreQuizText.text = scoreQuiz.ToString();


        AudioManager.instance.Quiz.Stop();
        AudioManager.instance.PlayMusicOnMenu();

        GameObject.Find("Button (1)").GetComponent<Button>().interactable = false;
        GameObject.Find("Button (2)").GetComponent<Button>().interactable = false;
        GameObject.Find("Button (3)").GetComponent<Button>().interactable = false;
        GameObject.Find("Button (4)").GetComponent<Button>().interactable = false;
        GameObject.Find("Button (5)").GetComponent<Button>().interactable = false;

        
    }

    void Update()
    {
        Chapter1();
        Chapter2();
        Chapter3();
        Chapter4();
        Chapter5();

    }


    public void Chapter1()
    {
        //PlayerData data = SaveSystem.LoadPlayer();
        //scoreQuiz = data.scoreQuiz;
        if (scoreQuiz >= scoreBond_1)
        {      
        GameObject.Find("Button (1)").GetComponent<Button>().interactable = true;
        }    
        else if(scoreQuiz < scoreBond_1)
        {
        //GameObject.Find("Button (1)").GetComponent<Button>().interactable = false;
        }
    }

    public void Chapter2()
    {
        //PlayerData data = SaveSystem.LoadPlayer();
        //scoreQuiz = data.scoreQuiz;
        if (scoreQuiz >= scoreBond_2)
        {      
        GameObject.Find("Button (2)").GetComponent<Button>().interactable = true;          
        }    
        else if(scoreQuiz < scoreBond_2)
        {
        //GameObject.Find("Button (2)").GetComponent<Button>().interactable = false;
        }
    }

    public void Chapter3()
    {
        //PlayerData data = SaveSystem.LoadPlayer();
        //scoreQuiz = data.scoreQuiz;
        //scoreQuizMode2 = data.scoreQuizMode2;
        if (scoreQuiz >= scoreBond_3)
        {      
        GameObject.Find("Button (3)").GetComponent<Button>().interactable = true;
        }    
        else if(scoreQuiz < scoreBond_3)
        {
        //GameObject.Find("Button (3)").GetComponent<Button>().interactable = false;
        }
    }

    public void Chapter4()
    {
       // PlayerData data = SaveSystem.LoadPlayer();
      //  scoreQuiz = data.scoreQuiz;
        if (scoreQuiz >= scoreBond_4)
        {      
        GameObject.Find("Button (4)").GetComponent<Button>().interactable = true;
        }    
        else if(scoreQuiz < scoreBond_4)
        {
        //GameObject.Find("Button (4)").GetComponent<Button>().interactable = false;
        }
    }

    public void Chapter5()
    {
       // PlayerData data = SaveSystem.LoadPlayer();
       // scoreQuiz = data.scoreQuiz;
        if (scoreQuiz >= scoreBond_5)
        {      
        GameObject.Find("Button (5)").GetComponent<Button>().interactable = true;
        }    
        else if(scoreQuiz < scoreBond_5)
        {
        //GameObject.Find("Button (5)").GetComponent<Button>().interactable = false;
        }
    }


}
