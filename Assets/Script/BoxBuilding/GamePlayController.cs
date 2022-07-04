using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{
    /*
    public static GamePlayController instance;

    public BoxSpawner boxSpawner;
    public ObstacleSpawner ObsSpawn;
    public Box currentBox;
    public CameraFollow cameraScipt;
    public float speedofBoxGravity;

    public float currentTime = 0f;
    public float startingTime = 10f;

    public int scoreBox = 0;

    [HideInInspector]
    public int moveCount;



    
    
    void Awake()
    {
        if(instance == null)
            instance = this;
    }
    
    
    void Start()
    {
        currentTime = startingTime;
        boxSpawner.SpawnBox();
        //ObsSpawn.SpawnObs();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if(currentTime >=0)
        {
            DetectInput();
        }
        else if(currentTime <=0)
        {
            DetectInput();
        }

        if(scoreBox == 30)
        {
            FinishGame();
            currentBox.canMove = false;
            speedofBoxGravity = 0;

        }
        
    }
    void DetectInput() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();

        }
    }

    public void SpawnNewBox()
    {
        Invoke("NewBox",0.1f);
    }

    void NewBox()
    {
        boxSpawner.SpawnBox();
    }

    public void MoveCamera() {
        moveCount++;

        if(moveCount ==3) {
            moveCount = 0;
            cameraScipt.targetPos.y += 1f;
        }
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
        );
    }

    public void FinishGame()
    {
        UICOntroller.instance.finishScreen.SetActive(true);
    }
    */
}
