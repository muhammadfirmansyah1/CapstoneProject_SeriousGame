using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueBase dialogue;
    //private bool playerInRange;

    public void TriggerDialogue()
    {
        DialogueManager.InstanceDialogueManager.EnqueueDialogue(dialogue);
    }

    /* private void Awake()
     {
         playerInRange = false;
     }*/

    /*
        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                playerInRange = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collider)
        {
            if (collider.gameObject.tag == "Player")
            {
                playerInRange = false;
            }
        }


        private void Update()
        {
            if (playerInRange)
            {
                TriggerDialogue();
            }
            else
            {
                DialogueManager.instance.EndDialogue();
            }

        } */
}
