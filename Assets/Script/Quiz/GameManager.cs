using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endScreen;
    TutorialBeforePlay tutorialBeforePlay;

    private PlayerController mcPos;

    public GameObject tombol;

    Player player;

    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endScreen = FindObjectOfType<EndScreen>();
        tutorialBeforePlay = FindObjectOfType<TutorialBeforePlay>();
        player = FindObjectOfType<Player>();
    }
    void Start()
    {

        tutorialBeforePlay.gameObject.SetActive(true);
        quiz.gameObject.SetActive(false);
        endScreen.gameObject.SetActive(false);

    }
            

  
    void Update()
    {
        if(tutorialBeforePlay.IsitStart == true)
        {
            quiz.gameObject.SetActive(true);
                if(quiz.isComplete)
                        {
                            quiz.gameObject.SetActive(false);
                            endScreen.gameObject.SetActive(true);
                            endScreen.ShowFinalScore();
                        }
        }
        
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   

    
    public void LoadDungeonPlease()
    {
       SceneManager.LoadScene("Chapters");
    }
}
