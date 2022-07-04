using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger_endgame : MonoBehaviour
{
    //public Animator endSteady;
    public Animator endNow;
    public GameObject buttonEnd;

    // Start is called before the first frame update
    void Start()
    {
        buttonEnd.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            buttonEnd.gameObject.SetActive(true);
            endNow.SetTrigger("colliding");
        }
    }

    public void EndNow()
    {
        SceneManager.LoadScene("Menu");
    }
}
