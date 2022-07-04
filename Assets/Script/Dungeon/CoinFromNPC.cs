using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFromNPC : MonoBehaviour
{
    public int coinValue = 1;
    public Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        Collider2D col = gameObject.GetComponent<Collider2D>();
        col.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            LevelManager.instance.GetCoins(coinValue);
            AudioManager.instance.PlaySFX(5);
            col.isTrigger = false;
        }
    }
}
