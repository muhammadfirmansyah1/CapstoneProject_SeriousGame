using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Rigidbody2D theRB;
    public float moveSpeed;
    //public Animator enemyidle;

    [SerializeField] private Transform bodyEnemy;

    public float rangeToChasePlayer;
    private Vector3 moveDirection;

    public int health = 150;
    public int stopFollow = 3;

    public GameObject[] deathSplatters;

    public GameObject hitEffect;
    public GameObject impactEffect;

    public bool shouldShoot;

    public GameObject bullet;
    public Transform firePoint;
    public float fireRate;
    private float fireCounter;

    public SpriteRenderer theBody;
    public float shootRange;

    public bool shouldDropitem;
    public GameObject[] itemsToDrop;
    public float itemDropPercent;

    public int EnemyDeath;

    PlayerController dashing;
    LevelTrackerDungeonQuiz abc;

    void Awake()
    {
        abc = FindObjectOfType<LevelTrackerDungeonQuiz>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
        if (theBody.isVisible && PlayerController.instance.gameObject.activeInHierarchy)
        {
            
            var Distance = Vector3.Distance(transform.position, PlayerController.instance.transform.position);
            if( Distance < rangeToChasePlayer)
            {
                
                moveDirection = PlayerController.instance.transform.position - transform.position;

                if(Distance <= stopFollow)
                {
                    moveDirection = Vector3.zero;
                }
            }
            else
            {
                moveDirection = Vector3.zero;
            }
            moveDirection.Normalize();
            theRB.velocity = moveDirection * moveSpeed;
            

            var EnemyPosition = bodyEnemy.transform.position.x;
            var MCPosition = PlayerController.instance.transform.position.x;

            if(EnemyPosition > MCPosition) 
            {
                 bodyEnemy.localScale = Vector3.one;
            }
            else
            {
                bodyEnemy.localScale = new Vector3(-1f,1f,1f);
            }
         
            if(shouldShoot && Vector3.Distance(transform.position, PlayerController.instance.transform.position) < shootRange)
            {
                fireCounter -= Time.deltaTime;
                if(fireCounter <=0)
                {
                    AudioManager.instance.EnemyMusicOnSCreen();
                    fireCounter = fireRate;
                    Instantiate(bullet, firePoint.position, firePoint.rotation);
                    AudioManager.instance.PlaySFX(13);
                }
            }
        }
        else{
            theRB.velocity = Vector2.zero;
        }
    }

    public void DamageEnemy(int damage)
    {
        health -= damage;

        Instantiate(hitEffect, transform.position, transform.rotation);
        AudioManager.instance.PlaySFX(2);

        if(health <= 0)
        {
           
            Destroy(gameObject);
            AudioManager.instance.PlaySFX(1);

            int selectedSplatters = Random.Range(0,deathSplatters.Length);
            int rotation = Random.Range(0,4);

            Instantiate(deathSplatters[selectedSplatters], transform.position, Quaternion.Euler(0f , 0f, rotation * 90));
            
        }
    }

    private void OnCollisionEnter2D(Collision2D target) {
        if(target.gameObject.tag == "Player")
        {
         //   health -= 50;
            Instantiate(impactEffect, transform.position, transform.rotation);
        }

        
        if(health <= 0)
        {
            
            Destroy(gameObject);
            AudioManager.instance.PlaySFX(1);

            int selectedSplatters = Random.Range(0,deathSplatters.Length);
            int rotation = Random.Range(0,4);

            Instantiate(deathSplatters[selectedSplatters], transform.position, Quaternion.Euler(0f , 0f, rotation * 90));

         /*   if(shouldDropitem)
                 {
                     float dropChance = Random.Range(0f, 100f);
                     if(dropChance < itemDropPercent)
                     {
                         int randomItem = Random.Range(0, itemsToDrop.Length);
                         Instantiate(itemsToDrop[randomItem], transform.position, transform.rotation);
                     }
                 } */
            
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Work");

        if(health <= 0)
        {
            abc.PlusEnemey(1);
            // Destroy(gameObject);
            gameObject.SetActive(false);
            AudioManager.instance.PlaySFX(1);

            int selectedSplatters = Random.Range(0,deathSplatters.Length);
            int rotation = Random.Range(0,4);

            Instantiate(deathSplatters[selectedSplatters], transform.position, Quaternion.Euler(0f , 0f, rotation * 90));

            if(shouldDropitem)
                 {
                     float dropChance = Random.Range(0f, 100f);
                     if(dropChance < itemDropPercent)
                     {
                         int randomItem = Random.Range(0, itemsToDrop.Length);
                         Instantiate(itemsToDrop[randomItem], transform.position, transform.rotation);
                     }
                 }}}}
