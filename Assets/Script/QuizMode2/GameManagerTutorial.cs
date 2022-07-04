using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerTutorial : MonoBehaviour
{
    public QuestionMode2[] questions;
    private static List<QuestionMode2> unanswerdQuestions;
    public QuestionMode2 currentQuestion;

    public GameObject PanelQuiz;

    public bool IsAnswered;


    [SerializeField]
    private Button button1;
    [SerializeField]
    private Button button2;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private Text trueAnswerText;

    [SerializeField]
    private Text falseAnswerText;

    [SerializeField]
    private float timeBtwQuestion = 1f;

    [SerializeField]
    Animator animator;

   

    ScoreKeeperQuizMode2 scoreKeeper;
    GameManagerAgain gma;

    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeperQuizMode2>();
        gma = FindObjectOfType<GameManagerAgain>();
    }

    void Start()
    {
        gma.EndScreen.gameObject.SetActive(false);
        if (unanswerdQuestions == null || unanswerdQuestions.Count == 0)
        {
            unanswerdQuestions = questions.ToList<QuestionMode2>();
        }

        SetCurrentQuestion();

        button1.GetComponent<Button>().onClick.AddListener(FalseButton);
        button2.GetComponent<Button>().onClick.AddListener(FalseButton);

    }

    void Update()
    {
        if (TimerQuizMode2.instance.IsComplete == true)
        {
            SetCurrentQuestion();
            EnableButton();
            TimerQuizMode2.instance.IsComplete = false;

           // if (unanswerdQuestions.Count < 0)
          //  {
             //   Time.timeScale = 0f;
           // }
        }

     //   if(scoreKeeper.scoreQuizMode2 == scoreKeeper.batasMenang)
     //   {
     //       //Time.timeScale = 0f;
     //   }


    }

    public void FalseButton()
    {
        TimerQuizMode2.instance.timer = 8;
        button1.GetComponent<Button>().interactable = false;
        button2.GetComponent<Button>().interactable = false;
    }

    public void EnableButton()
    {
        button1.GetComponent<Button>().interactable = true;
        button2.GetComponent<Button>().interactable = true;
    }


    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unanswerdQuestions.Count);
        currentQuestion = unanswerdQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;

        if(currentQuestion.isTrue)
        {
            trueAnswerText.text = "JAWABAN KAMU BENAR";
            falseAnswerText.text = "JAWABAN KAMU SALAH";
        } else
        {
            trueAnswerText.text = "JAWABAN KAMU SALAH";
            falseAnswerText.text = "JAWABAN KAMU BENAR";
        }
        unanswerdQuestions.RemoveAt(randomQuestionIndex);
        if(unanswerdQuestions == null || unanswerdQuestions.Count == 0)
        {
            unanswerdQuestions = questions.ToList<QuestionMode2>();
            PanelQuiz.gameObject.SetActive(false);
            //unanswerdQuestions.RemoveRange(0, 1);
            gma.EndScreen.gameObject.SetActive(true);   
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unanswerdQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBtwQuestion);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
        
        if(currentQuestion.isTrue)
        {
            Debug.Log("Correct");
            animator.SetTrigger("True");
            scoreKeeper.IncrementScore();
        } else
        {
            Debug.Log("Wrong");
            animator.SetTrigger("True");
        }   
    }

    public void UserSelectFalse()
    {
        
        if (!currentQuestion.isTrue)
        {
            Debug.Log("Correct");
            animator.SetTrigger("False");
            scoreKeeper.IncrementScore();
        }
        else
        {
            Debug.Log("Wrong");
            animator.SetTrigger("False");
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Quiz-Fact");
    }

}
