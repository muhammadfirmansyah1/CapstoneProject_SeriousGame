using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score2 : MonoBehaviour
{
    ObjectToCatch obj;

    [Header("Persiapan")]
    public GameObject FirstPage;
    public bool IsitStart;

    [Header("Timer")]
    [SerializeField]public float timer = 60;
    public Text timerText;
    

    [Header("Scoring")]
    public int Score;
    public int ScoreRewards;
    public Text ScoreText;
    public Text ScoreRewardsText;
    public GameObject imageePindahScene;

    [Header("Rewards")]
    public float coinToGet = 10f;


    void Awake()
    {
        obj = FindObjectOfType<ObjectToCatch>();    
    }

    void Start()
    {
        IsitStart = false;
        if(IsitStart == false)
        {
         FirstPage.SetActive(true);
         Time.timeScale = 0f;
         imageePindahScene.SetActive(false);
        }
    }

    void Update()
    {
        timer = timer - Time.deltaTime;
        timerText.text = Mathf.RoundToInt(timer).ToString();

        if(timer <= 0)
        {
            YouWin();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "ObjectPlus")
        {
            AddScore();
            Destroy(other.gameObject);
        } else if(other.gameObject.tag == "ObjectMinus")
        {
            MinusScore();
            Destroy(other.gameObject);
        }
        
    }

    void YouWin()
    {
        ScoreText.text = "You Win";
        imageePindahScene.SetActive(true);

        ScoreRewards = Score;
        ScoreRewardsText.text = "Skor totalmu adalah ..... \n" + ScoreRewards.ToString();
        LevelManager.instance.currentCoins = LevelManager.instance.currentCoins + Mathf.RoundToInt(Score*coinToGet);
        gameObject.SetActive(false);
    }

    void AddScore()
    {
        Score = Score + ObjectToCatch._objectToCatch.amountScoreObj;
        ScoreText.text = Score.ToString();
        AudioManager.instance.PlaySFX(5);
    }

    void MinusScore()
    {
        Score = Score - ObjectToCatch._objectToCatch.amountScoreObj;
        ScoreText.text = Score.ToString();
        AudioManager.instance.PlaySFX(11);
    }

    public void ReadyToPlay()
    {
        IsitStart = true;
        FirstPage.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("StackBuilding");
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Dungeon");
        
    }





































    /*
    Box scorePoint;
    HighScoreBox highScore;
    
    public int scoreBoxText2 = 0;

    public Text scoreText;
    

    void Awake() {
        scorePoint = GetComponent<Box>();
    }

    void Update() {
       scoreBoxText2 = GamePlayController.instance.scoreBox;   
       scoreText.text = scoreBoxText2.ToString(); 
    }
    */

}
