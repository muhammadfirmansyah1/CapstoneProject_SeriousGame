using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;

    public void Start()
    {
       
    }


    void Update()
    {
    }

    public void SpawnPoint()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        PlayerController.instance.transform.position = gm.lastCheckPoint;
        var LastPos = transform.position;
        SceneManager.LoadScene("Dungeon");
    }
}
