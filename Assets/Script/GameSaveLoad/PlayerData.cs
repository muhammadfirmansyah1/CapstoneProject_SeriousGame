using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int scoreQuiz;
    public float coba;
   // public int scoreQuizMode2;

    public  PlayerData(Player player)
    {
        scoreQuiz = player.scoreQuiz;
       // scoreQuizMode2 = player.scoreQuizMode2;
        coba = player.coba;
    }
    
}
