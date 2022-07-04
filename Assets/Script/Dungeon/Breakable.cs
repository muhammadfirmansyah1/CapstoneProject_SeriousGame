using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Breakable : MonoBehaviour
{
    public GameObject[] brokenPieces;
    public int maxDrop = 5;
    public bool shouldDropitem;
    public GameObject[] itemsToDrop;
    public float itemDropPercent;

    ChestforEduc chest;
    //public GameObject chestEduc;

    void Start()
    {
        
    }
    void Update()
    {
    
    }

    //script untuk dashing destroy object di depannya menggunakan collison
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            if(PlayerController.instance.dashCounter > 0)
            {
                Smash();
                //chestEduc.SetActive(true);
            }

        }
        if(other.tag == "Player")
        {
            Smash();
        }
    }

    public void Smash()
    {
                 Destroy(gameObject);
                 AudioManager.instance.PlaySFX(0);

                 int piecesDrop = Random.Range(1,maxDrop);
                 for(int i = 0; i < piecesDrop; i++)
                 {
                     
                     int randomPiece = Random.Range(0, brokenPieces.Length);
                     var a = Instantiate(brokenPieces[randomPiece], transform.position, transform.rotation);
                     
                     for(int j = 0; j < maxDrop; j++)
                     {
                         Destroy(a, 2f);
                     }
                 }
                 //item drop
                 if(shouldDropitem)
                 {
                     float dropChance = Random.Range(0f, 100f);
                     if(dropChance < itemDropPercent)
                     {
                         int randomItem = Random.Range(0, itemsToDrop.Length);
                         Instantiate(itemsToDrop[randomItem], transform.position, transform.rotation);
                     }
                 }
    }


}
