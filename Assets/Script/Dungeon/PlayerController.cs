using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [SerializeField] private Transform gunArm;
    public Transform Body;
    private Camera theCam;
    public GameObject bulletToFire;
    public Transform firePoint;
    public Animator anim;
    public int health = 200;


    public GameObject hitEffect;
    public float timeBetweenShots;
    private float shotCounter;
    public SpriteRenderer bodySR;

    [Header("PlayerDash")]
    private float activeMoveSpeed;
    public float dashSpeed = 8f;
    public float dashLength = .5f;
    public float dashCooldown = 1f;
    public int dashTime = 2;
    public int dashTimeTimer = 2;
    public int dashTimeAgain = 1; 
    public float dashInvin = .5f;
    [HideInInspector]
    public float dashCounter;
    private float dashCoolCounter;

    [Header("PlayerMoving")]
    [SerializeField] private float moveSpeed;
    private Vector2 moveInput;
    public Rigidbody2D theRB;

    private bool moveLeft;
    public bool dontMove;
    public bool dontMove1;
    private bool moveUp;

    [Header("PlayerSpawnPoint")]
    public Vector2 spawnPoint;
    public Vector2 spawnPoint2;
    public Vector2 spawnPoint3;
    public Vector2 spawnPoint4;
    public Vector2 spawnPoint5;
    public Vector2 spawnPoint6;
    public GameObject spawnTransform1;
    public GameObject spawnTransform2;
    public GameObject spawnTransform3;
    public GameObject spawnTransform4;
    public GameObject spawnTransform5;
    public GameObject spawnTransform6;

    [Header("PlayerSpawnAfterCatchFruits")]
    public Transform spawnPointAfterPlayBox;
    public Transform spawnPointAfterPlayBox2;
    public Transform spawnPointAfterPlayBox3;
    public Transform spawnPointAfterPlayBox4;
    public Transform spawnPointAfterPlayBox5;


    PlayerHealthController playerHP;




    // [Header("Time to Wait")]
    // [Header("Time to Wait")]
    //[Header("Time to Wait")]
    //public float time = 100f;
    //private float timeCounter = 10f;

    void Awake()
    {
        playerHP = FindObjectOfType<PlayerHealthController>();
            instance = this;
    }

    void Start()
    {

        if (PickChapter1.instance.chapter1 == true /*&& PickChapter1.instance.chapter2 == false && PickChapter1.instance.chapter3 == false*/)
        {
            Chapter1Pick();
        }
        else if (PickChapter1.instance.chapter2 == true)//&& PickChapter1.instance.chapter2 == true && PickChapter1.instance.chapter3 == false)
        {
            Chapter2Pick();

        } 
        else if(PickChapter1.instance.chapter3 == true )//&& PickChapter1.instance.chapter2 == false && PickChapter1.instance.chapter3 == true)
        {
            Chapter3Pick();
        }
        else if (PickChapter1.instance.chapter4 == true)// && PickChapter1.instance.chapter2 == true && PickChapter1.instance.chapter3 == false)
        {
            Chapter4Pick();
        }
        else if (PickChapter1.instance.chapter5 == true)// && PickChapter1.instance.chapter2 == true && PickChapter1.instance.chapter3 == false)
        {
            Chapter5Pick();
        }
        else if (PickChapter1.instance.chapter6 == true)// && PickChapter1.instance.chapter2 == true && PickChapter1.instance.chapter3 == false)
        {
            Chapter6Pick();
        }
        else if(PickChapter1.instance.chapter1 == false && PickChapter1.instance.chapter2 == false && PickChapter1.instance.chapter3 == false && PickChapter1.instance.chapter4 == false && PickChapter1.instance.chapter5 == false && PickChapter1.instance.chapter6 == false)
        {
            if(PickChapter1.instance.ch_TB1 == true)
            {
                transform.position = spawnPointAfterPlayBox.transform.position;
            } 
            else if (PickChapter1.instance.ch_TB2 == true)
            {
                transform.position = spawnPointAfterPlayBox2.transform.position;
            }
            else if (PickChapter1.instance.ch_TB3 == true)
            {
                transform.position = spawnPointAfterPlayBox3.transform.position;
            }
            else if (PickChapter1.instance.ch_TB4 == true)
            {
                transform.position = spawnPointAfterPlayBox4.transform.position;
            }
            else if (PickChapter1.instance.ch_TB5 == true)
            {
                transform.position = spawnPointAfterPlayBox5.transform.position;
            }

        }

        PickChapter1.instance.chapter1 = false;
        PickChapter1.instance.chapter2 = false;
        PickChapter1.instance.chapter3 = false;
        PickChapter1.instance.chapter4 = false;
        PickChapter1.instance.chapter5 = false;
        PickChapter1.instance.chapter6 = false;


        theRB = GetComponent<Rigidbody2D>();
        dontMove = true;
        dontMove1 = true;
        theCam = Camera.main;
        activeMoveSpeed = moveSpeed;

    }

    void Update()
    {

        HandleMoving1();
        HandleMoving();
        AnimWalk();

    }

    public void Chapter1Pick()
    {
        spawnPoint.x = spawnTransform1.transform.position.x;
        spawnPoint.y = spawnTransform1.transform.position.y;
        transform.position = spawnPoint;
    }

    public void Chapter2Pick()
    {
        spawnPoint2.x = spawnTransform2.transform.position.x;
        spawnPoint2.y = spawnTransform2.transform.position.y;
        transform.position = spawnPoint2;
    }

    public void Chapter3Pick()
    {
        spawnPoint3.x = spawnTransform3.transform.position.x;
        spawnPoint3.y = spawnTransform3.transform.position.y;
        transform.position = spawnPoint3;
    }

    public void Chapter4Pick()
    {
        spawnPoint4.x = spawnTransform4.transform.position.x;
        spawnPoint4.y = spawnTransform4.transform.position.y;
        transform.position = spawnPoint4;
    }

    public void Chapter5Pick()
    {
        spawnPoint5.x = spawnTransform5.transform.position.x;
        spawnPoint5.y = spawnTransform5.transform.position.y;
        transform.position = spawnPoint5;
    }

    public void Chapter6Pick()
    {
        spawnPoint6.x = spawnTransform6.transform.position.x;
        spawnPoint6.y = spawnTransform6.transform.position.y;
        transform.position = spawnPoint6;
    }



    void HandleMoving()
    {
        if (dontMove)
        {
            StopMoving();
        }
        else
        {
            if (moveLeft)
            {
                MoveLeft();
            }
            else if (!moveLeft)
            {
                MoveRight();
            }
        }
    }
    public void HandleMoving1()
    {
        if (dontMove1)
        {
            StopMoving1();
        }
        else
        {
            if (moveUp)
            {
                MoveUp();
            }
            else if (!moveUp)
            {
                MoveDown();
            }
        }
    }

    public void AllowMovement(bool movement)
    {
        dontMove = false;
        moveLeft = movement;
    }

    public void DontAllowMovement()
    {
        dontMove = true;
    }

    public void AllowMovement1(bool movement)
    {
        dontMove1 = false;
        moveUp = movement;
    }

    public void DontAllowMovement1()
    {
        dontMove1 = true;
    }

    public void AnimWalk()
    {
        if (dontMove == false)
        {
            anim.SetBool("isMoving", true);
        }
        else if (dontMove1 == false)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }

    public void MoveLeft()
    {
        theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
        Body.localScale = new Vector3(-1f, 1f, 1f);
        gunArm.localScale = new Vector3(1f, -1f, 1f);
    }
    public void MoveRight()
    {
        theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
        Body.localScale = Vector3.one;
        gunArm.localScale = Vector3.one;
    }
    public void MoveUp()
    {
        theRB.velocity = new Vector2(theRB.velocity.x, moveSpeed);
    }
    public void MoveDown()
    {
        theRB.velocity = new Vector2(theRB.velocity.x, -moveSpeed);

    }
    public void StopMoving()
    {
        theRB.velocity = new Vector2(0f, theRB.velocity.y);

    }
    public void StopMoving1()
    {
        theRB.velocity = new Vector2(theRB.velocity.x, 0f);
    }

    void DetectInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (x > 0)
        {
            MoveRight();
        }
        else if (x < 0)
        {
            MoveLeft();
        }
        else if (y < 0)
        {
            MoveDown();
        }
        else if (y > 0)
        {
            MoveUp();
        }
        else
        {
            StopMoving();
        }
    }

    public void Dashing()
    {
        if( LevelManager.instance.currentTimeforDash >= dashTimeTimer)
        {
            anim.SetTrigger("dash");
            PlayerHealthController.instance.MakeInvincible(dashInvin);
           // playerHP.MakeInvincible(dashInvin);
            AudioManager.instance.PlaySFX(8);
            LevelManager.instance.SpendDashCounter(dashTimeAgain);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(hitEffect, transform.position, transform.rotation);
    }

}

