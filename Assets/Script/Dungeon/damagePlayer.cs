using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{
    PlayerHealthController playerHP;
    // Start is called before the first frame update

    private void Awake()
    {
        playerHP = FindObjectOfType<PlayerHealthController>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            PlayerHealthController.instance.DamagePlayer();
            //playerHP.DamagePlayer();
        }
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            PlayerHealthController.instance.DamagePlayer();
            //playerHP.DamagePlayer();
        }
    }

    private void OnColiisonEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerHealthController.instance.DamagePlayer();
            //playerHP.DamagePlayer();
        }
    }
     private void OnColiisonStay2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerHealthController.instance.DamagePlayer();
            //playerHP.DamagePlayer();
        }
    }

    
}
