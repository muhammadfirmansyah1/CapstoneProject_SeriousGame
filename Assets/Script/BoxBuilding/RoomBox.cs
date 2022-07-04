using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomBox : MonoBehaviour
{
    //public Animator animTransition;
    public float transitionTime = 1f;

    [SerializeField] private Transform MC;

    //private GameMaster gm;
    //private PlayerController mcPos;
    PlayerPos playerPos;

    

    void Start()
    { 
    }
    
    void Update()
    {
    }


    public void LoadDungeonPlease()
    {
        //animTransition.SetTrigger("Start");
       // yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("Chapters");
        
        //
            //transform.position;
            
        //
    }

    public void LoadDungeon()
    {
        SceneManager.LoadScene("Dungeon");
        //MC.transform.position = PlayerController.instance.spawnPointAfterPlayBox.transform.position;
        LevelManager.instance.currentCoins = LevelManager.instance.currentCoins + 3;
    }


}
