using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerQuizMode2 : MonoBehaviour
{
    public static TimerQuizMode2 instance;

    [SerializeField]
    public float timer;
    public bool IsComplete = false;
    public Text timerText;
    GameManagerTutorial gameManager;
    void Awake()
    {
        instance = this;
        gameManager = FindObjectOfType<GameManagerTutorial>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        timerText.text = Mathf.RoundToInt(timer).ToString();

        if(timer <= 0)
        {
            IsComplete = true;
            timer += 120;
        }
    }
}
