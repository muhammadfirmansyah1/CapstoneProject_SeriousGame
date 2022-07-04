using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomToQuiz : MonoBehaviour
{
    //public GameObject MC;
    public Animator animTransition;
    public float transitionTime = 1f;

    [SerializeField] bool quiz_1;
    [SerializeField] bool quiz_2;

    public GameObject buttonToQuiz;
    public GameObject Warning;

    LevelTrackerDungeonQuiz trackQuiz;

    private void Awake()
    {
        trackQuiz = FindObjectOfType<LevelTrackerDungeonQuiz>();
    }

    void Start()
    {
        buttonToQuiz.SetActive(false);
        Warning.SetActive(false);
    }
    
    void Update()
    {
     //   Debug.Log(PlayerPrefs.GetFloat("MC_X"));
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            if (PickChapter1.instance.ch_TB1 == true)
            {
                if(trackQuiz.Q1 == true)
                {
                    buttonToQuiz.SetActive(true);
                } else if(trackQuiz.Q1 == false)
                {
                    Warning.SetActive(true);
                }
            }
            else if (PickChapter1.instance.ch_TB2 == true)
            {
                if (trackQuiz.Q2 == true)
                {
                    buttonToQuiz.SetActive(true);
                }
                else if (trackQuiz.Q2 == false)
                {
                    Warning.SetActive(true);
                }

            }
            else if (PickChapter1.instance.ch_TB3 == true)
            {
                if (trackQuiz.Q3 == true)
                {
                    buttonToQuiz.SetActive(true);
                }
                else if (trackQuiz.Q3 == false)
                {
                    Warning.SetActive(true);
                }
            }
            else if (PickChapter1.instance.ch_TB4 == true)
            {
                if (trackQuiz.Q4 == true)
                {
                    buttonToQuiz.SetActive(true);
                }
                else if (trackQuiz.Q4 == false)
                {
                    Warning.SetActive(true);
                }
            }
            else if (PickChapter1.instance.ch_TB5 == true)
            {
                if (trackQuiz.Q5 == true)
                {
                    buttonToQuiz.SetActive(true);
                }
                else if (trackQuiz.Q5 == false)
                {
                    Warning.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {        
            buttonToQuiz.SetActive(false);
            Warning.SetActive(false);
        }
    }



    public void LoadQuiz()
    {
        //StartCoroutine(LoadLevelQuiz(SceneManager.LoadScene("Quiz")));
        SceneManager.LoadScene("Quiz-Pilgan-1");
    }

    public void LoadQuiz1()
    {
        //StartCoroutine(LoadLevelQuiz(SceneManager.LoadScene("Quiz")));
        SceneManager.LoadScene("Quiz-Pilgan-2");
    }

    public void LoadQuiz2()
    {
        //StartCoroutine(LoadLevelQuiz(SceneManager.LoadScene("Quiz")));
        SceneManager.LoadScene("Quiz-Fact");
    }

    public void LoadQuiz3()
    {
        //StartCoroutine(LoadLevelQuiz(SceneManager.LoadScene("Quiz")));
        SceneManager.LoadScene("Quiz-Pilgan-3");
    }

    public void LoadQuiz4()
    {
        //StartCoroutine(LoadLevelQuiz(SceneManager.LoadScene("Quiz")));
        SceneManager.LoadScene("Quiz-Nasihat");
    }

    /*
    IEnumerator LoadLevelQuiz(int LevelIndex)
    {
        animTransition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(LevelIndex);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            if(quiz_1 == true)
            {
                LoadQuiz();
            } else if ( quiz_2 == true)
            {
                LoadQuiz1();
            }
        }
    }
    */
}
