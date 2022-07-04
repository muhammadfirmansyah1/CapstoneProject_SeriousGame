using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour
{
    public GameObject DialogueButton;
    private void Start()
    {
        DialogueButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            DialogueButton.SetActive(true);
            //StartCoroutine("WaitForSec");
        }

    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            DialogueButton.SetActive(false);
        }

    }

    /*
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        Destroy(DialogueButton);
        Destroy(gameObject);
    }*/
}
