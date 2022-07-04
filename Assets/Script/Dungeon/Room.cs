using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room : MonoBehaviour
{
    //public GameObject MC;
    //public Animator animTransition;
    //public float transitionTime = 1f;

    public GameObject buttonToFruitsGame;

    public Sprite[] bg_TangkapBuah;
    public GameObject bg;

    private void Start()
    {
        buttonToFruitsGame.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Player")
            {
                buttonToFruitsGame.SetActive(true);

            }  
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            buttonToFruitsGame.SetActive(false);
        }
    }

    public void LoadStackBuilding()
    {
       SceneManager.LoadScene("StackBuilding");
    }

}
