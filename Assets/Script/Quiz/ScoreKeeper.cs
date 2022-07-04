using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    Quiz quiz;
    QuestionSO currentQuestion;

    public static ScoreKeeper instance;

    int correctAnswer = 0;
    int questionsSeen = 0;
    public int abc;





    [Header("ProgressHealth")]
    public GameObject image;
    public int correctIndexImage;
    public Sprite[] imageHealth = new Sprite[2];

    [Header("ProgressBar")]
    [SerializeField]public  Slider progressBarforHealth;
    [SerializeField] public GameObject BarforHealth;
    public float cek;

    [Header("Identifier")]
    [SerializeField] bool quiz_1;

    void Awake()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Nasihat"))
        {

            BarforHealth.GetComponent<Image>().color = new Color(255, 0, 0);
        }
        /*
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(instance.gameObject);
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        */

        if (quiz_1 == true)
        {
        quiz = FindObjectOfType<Quiz>();
        progressBarforHealth.maxValue = quiz.questions.Count;
        progressBarforHealth.value = 0;
        }

    }

    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Quiz-Nasihat"))
        {
            if (quiz_1 == true)
                    {
                        if(progressBarforHealth.value >= 3)
                        {
                            image.GetComponent<Image>().sprite = imageHealth[0];
                            BarforHealth.GetComponent<Image>().color = new Color(0, 255, 0);
                        } else if (progressBarforHealth.value < 4)
                        {
                            image.GetComponent<Image>().sprite = imageHealth[1];
                            BarforHealth.GetComponent<Image>().color = new Color(255, 0, 0);
                        }
                    }
        }

    }


    public int GetCorrectAnswer()
    {
        return correctAnswer;
    }

    public void IncrementCorrectAnswer()
    {
        //correctAnswer++;
        correctAnswer += 10;
        if(quiz_1 == true)
        {
        progressBarforHealth.value++;
        }
        
    }

    public void IncrementIncorrectAnswer()
    {
        //correctAnswer++;
        correctAnswer -= 10;
        
        if(correctAnswer<0)
        {
            correctAnswer = 0;
            progressBarforHealth.value=0;
        }

        if(quiz_1 == true)
        {
            progressBarforHealth.value--;
        }
    }

    public int GetQuestionSeen()
    {
        return questionsSeen;
    }
    public void IncrementQuestionsSeen()
    {
        //questionsSeen++;
        questionsSeen += 0;
    }
    public int CalculateScore()
    {
        abc = correctAnswer;
        return abc;
    }
    
}
