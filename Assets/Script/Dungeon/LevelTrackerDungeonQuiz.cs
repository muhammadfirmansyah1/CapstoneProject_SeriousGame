using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTrackerDungeonQuiz : MonoBehaviour
{

    public Text enemyCountText;

    public int EnemyDeathCount;

    [SerializeField] public List<GameObject> Quiz1;
    [SerializeField] public List<GameObject> Quiz2;
    [SerializeField] public List<GameObject> Quiz3;
    [SerializeField] public List<GameObject> Quiz4;
    [SerializeField] public List<GameObject> Quiz5;

    [HideInInspector]
    public bool Q1 = false;
    [HideInInspector]
    public bool Q2 = false;
    [HideInInspector]
    public bool Q3 = false;
    [HideInInspector]
    public bool Q4 = false;
    [HideInInspector]
    public bool Q5 = false;


   void Awake()
    {
    }


    // Start is called before the first frame update
    void Start()
    {
        Q1 = false;
        Q2 = false;
        Q3 = false;
        Q4 = false;
        Q5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCountText.text = EnemyDeathCount.ToString();

        if(EnemyDeathCount == Quiz1.Count)
        {
            Q1 = true;
        }
        else if(EnemyDeathCount == Quiz2.Count)
        {
            Q2 = true;
        }
        else if (EnemyDeathCount == Quiz3.Count)
        {
            Q3 = true;
        }
        else if (EnemyDeathCount == Quiz4.Count)
        {
            Q4 = true;
        }
        else if (EnemyDeathCount == Quiz5.Count)
        {
            Q5 = true;
        }
    }

    public void PlusEnemey(int amount)
    {
        EnemyDeathCount += amount;
    }
}
