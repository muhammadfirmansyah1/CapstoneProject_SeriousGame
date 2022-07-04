using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialBeforePlay : MonoBehaviour
{
    [Header("Persiapan")]
    public GameObject FirstPage;
    public bool IsitStart;

    Player player;
    GameManagerTutorial gmt;
    GameManagerAgain gma;

    private void Awake()
    {
        gmt = FindObjectOfType<GameManagerTutorial>();
        gma = FindObjectOfType<GameManagerAgain>();
        player = FindObjectOfType<Player>();
    }

    void Start()
    {
        FirstPage.SetActive(true);
        Time.timeScale = 0f;
        AudioManager.instance.QuizMusicBegin();
    }

    
    void Update()
    {
        
    }

    public void ReadyToPlay()
    {
        FirstPage.SetActive(false);
        IsitStart = true;
        Time.timeScale = 1f;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Fact"))
        {
            gma.EndScreen.gameObject.SetActive(false);
            gmt.PanelQuiz.gameObject.SetActive(true);
          }  
    }

    public void BacktoChapters()
    {
        Time.timeScale = 1f;
        player.SaveCoba();
        SceneManager.LoadScene("Chapters");
    }
}
