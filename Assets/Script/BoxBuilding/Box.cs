using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    /*
    public static Box instance;
    
    private float minX = -5f, maxX = 5f;
    public bool canMove;
    private float moveSpeed= 8f;
    private Rigidbody2D myBody;
    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;

    
    


    private void Awake() 
    {
        instance = this;
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        if(Random.Range(0,2)>0){
            moveSpeed *= -1f;
        }
        GamePlayController.instance.currentBox = this;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBox();
    }

    void MoveBox()
    {
        if(canMove)
        {
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;
            if(temp.x >= maxX)
            {
                moveSpeed *= -1f;
            } else if (temp.x <= minX)
            {
                moveSpeed *= -1f;
            }
            transform.position = temp;
        }
    }
    public void DropBox()
    {
        canMove = false;
        myBody.gravityScale = GamePlayController.instance.speedofBoxGravity;
    }

    public void ScoreBox()
    {
        GamePlayController.instance.scoreBox += 10;
    }

    public void ScoreBoxMinus()
    {
        GamePlayController.instance.scoreBox -= 10;
        if(GamePlayController.instance.scoreBox <= 0)
        {
            GamePlayController.instance.scoreBox = 0;
        }
    }

    public void Landed()
    {
        if(gameOver)
        return;

        ignoreCollision = true;
        ignoreTrigger = true;

        GamePlayController.instance.SpawnNewBox();
        GamePlayController.instance.MoveCamera();
    }

    void RestartGame()
    {
        GamePlayController.instance.RestartGame();
    }

    public void FinishGame()
    {
        UICOntroller.instance.finishScreen.SetActive(true);
        Destroy(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D target) {
        if(ignoreCollision)
        return;

        if(target.gameObject.tag == "BoxBase")
        {
            Invoke("Landed",1f);
            ignoreCollision = true;
            ScoreBox();
            
        }
         if(target.gameObject.tag == "Box")
        {
            Invoke("Landed",1f);
            ignoreCollision = true;
            ScoreBox();
        }

        if(target.gameObject.tag == "ObstacleBox")
        {
            ScoreBoxMinus();
        }
    }

    private void OnTriggerEnter2D(Collider2D target) {
        if(ignoreTrigger)
        return;

        if(target.tag == "GameOver")
        {
            CancelInvoke("Landed");
            gameOver = true;
            ignoreTrigger= true;
            Invoke("RestartGame", 0.5f);
        }
       /* if(target.tag == "BoxFinish")
        {
            Invoke("FinishGame",0.1f);
        } */

}

   
   

