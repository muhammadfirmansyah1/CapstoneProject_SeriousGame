using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskPickUp : MonoBehaviour
{
    public int dashTimeAgain = 1;
    public float waitToBeCollected;

    void Update()
    {
        if(waitToBeCollected > 0)
        {
            waitToBeCollected -=Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && waitToBeCollected <=0)
        {
            LevelManager.instance.GetDashCounter(dashTimeAgain);
            Destroy(gameObject);
            AudioManager.instance.PlaySFX(5);
        }
    }
}
