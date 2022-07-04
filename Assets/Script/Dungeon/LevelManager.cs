using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int currentCoins;
    public int currentTimeforDash = 10; 
    public GameObject transitionSlide;

    Player player;

    void Awake()
    {
        if(instance == null)
        {
            instance= this;
            DontDestroyOnLoad(instance);
        } else
        {
            Destroy(gameObject);
        } 
        // GameObject transitionSlide = gameObject.GetComponent<GameObject>();
        //transitionSlide.SetActive(true);
    }

    void Start()
    {  
    }

    void Update()
    {
    }


    public void GetCoins(int amount)
    {
        currentCoins += amount;
        UIController.instance.coinMC.text = currentCoins.ToString();
    }
    public void SpendCoins(int amount)
    {
        currentCoins -= amount;
        if(currentCoins<0)
        {
            currentCoins = 0;
        }
        UIController.instance.coinMC.text = currentCoins.ToString();
    }

    public void GetDashCounter(int time)
    {
        currentTimeforDash += time;
        UIController.instance.mask.text = currentCoins.ToString();
    }

    public void SpendDashCounter(int time)
    {
        currentTimeforDash -= time;
        if(currentTimeforDash < 0)
        {
            currentTimeforDash =0;
        }
        UIController.instance.mask.text = currentCoins.ToString();
    }

    
    
    
}
