using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBox : MonoBehaviour
{
    
    public float currentTime = 0f;
    [SerializeField]public float startingTime = 10f;

   
    void Start()
    {
        currentTime = startingTime;
    }

    void TimerBx() 
    {
        currentTime -= 1 * Time.deltaTime;
    }
}
