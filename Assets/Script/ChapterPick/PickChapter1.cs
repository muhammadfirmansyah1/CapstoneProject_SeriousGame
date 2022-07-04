using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickChapter1 : MonoBehaviour
{
    public static PickChapter1 instance;
    public bool chapter1;
    public bool chapter2;
    public bool chapter3;
    public bool chapter4;
    public bool chapter5;
    public bool chapter6;
    PlayerController spawn;

    [Header("GameTangkapBuah")]
    public bool ch_TB1;
    public bool ch_TB2;
    public bool ch_TB3;
    public bool ch_TB4;
    public bool ch_TB5;


    void Awake()
    {
        //instance= this;

        if (instance == null)
        {
            //First run, set the instance
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else if (instance != this)
        {
            //Instance is not the same as the one we have, destroy old one, and reset to newest one
            Destroy(instance.gameObject);
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
       // spawn = FindObjectOfType<PlayerController>();
       chapter1 = true;
       chapter2 = false;
       chapter3 = false;
       chapter4 = false;
       chapter5 = false;
       chapter6 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadSceneChapter1()
    {
        chapter1 =true;
        chapter2 =false;
        chapter3 =false;
        chapter4 = false;
        chapter5 = false;
        chapter6 = false;

        ch_TB1 = true;
        ch_TB2 = false;
        ch_TB3 = false;
        ch_TB4 = false;
        ch_TB5 = false;



        SceneManager.LoadScene("Dungeon"); 
    }

    public void LoadSceneChapter2()
    {
        chapter1 = false;
        chapter2 = true;
        chapter3 = false;
        chapter4 = false;
        chapter5 = false;
        chapter6 = false;

        ch_TB1 = false;
        ch_TB2 = true;
        ch_TB3 = false;
        ch_TB4 = false;
        ch_TB5 = false;

        SceneManager.LoadScene("Dungeon");
    }
    
     public void LoadSceneChapter3()
    {
        chapter1 = false;
        chapter2 = false;
        chapter3 = true;
        chapter4 = false;
        chapter5 = false;
        chapter6 = false;

        ch_TB1 = false;
        ch_TB2 = false;
        ch_TB3 = true;
        ch_TB4 = false;
        ch_TB5 = false;


        SceneManager.LoadScene("Dungeon");
    }

    public void LoadSceneChapter4()
    {
        chapter1 = false;
        chapter2 = false;
        chapter3 = false;
        chapter4 = true;
        chapter5 = false;
        chapter6 = false;

        ch_TB1 = false;
        ch_TB2 = false;
        ch_TB3 = false;
        ch_TB4 = true;
        ch_TB5 = false;

        SceneManager.LoadScene("Dungeon");
    }
    public void LoadSceneChapter5()
    {
        chapter1 = false;
        chapter2 = false;
        chapter3 = false;
        chapter4 = false;
        chapter5 = true;
        chapter6 = false;

        ch_TB1 = false;
        ch_TB2 = false;
        ch_TB3 = false;
        ch_TB4 = false;
        ch_TB5 = true;

        SceneManager.LoadScene("Dungeon");
    }

    public void LoadSceneChapter6()
    {
        chapter1 = false;
        chapter2 = false;
        chapter3 = false;
        chapter4 = false;
        chapter5 = false;
        chapter6 = true;
        SceneManager.LoadScene("Dungeon");
    }

}
