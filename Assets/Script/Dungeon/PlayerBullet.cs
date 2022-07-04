using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 7.5f;
    public Rigidbody2D theRB;
    public GameObject impactEffect;
    public int damageToGive = 50;
    
    void Start()
    {
        
    }

    void Update()
    {
        theRB.velocity = transform.right * speed ;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {

        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);

        AudioManager.instance.PlaySFX(4);
        
        if(other.tag == "Enemy1")
        {
            
            other.GetComponent<EnemyController>().DamageEnemy(damageToGive);
        }
    }
    private void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
}
