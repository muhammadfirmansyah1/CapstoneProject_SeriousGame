using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalscoreText;
    ScoreKeeper scoreKeeper;
    Player player;

    void Awake() {
        {
            scoreKeeper = FindObjectOfType<ScoreKeeper>();
            player = FindObjectOfType<Player>();
        }
    }
    public void ShowFinalScore()
    {
        finalscoreText.text = scoreKeeper.CalculateScore().ToString();
        player.SaveCoba();
    }
}
