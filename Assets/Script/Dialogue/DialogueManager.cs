using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;
//using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager InstanceDialogueManager;
    
    private void Awake()
    {
        if (InstanceDialogueManager != null)
        {
            Debug.LogWarning(("fix this") + gameObject.name);
        }
        else
        {
            InstanceDialogueManager = this;
        }
    }

    public GameObject dialoguePanel;
    
    public Text dialogueName;
    public Text dialogueText;
    public Image dialoguePortrait;
    public float delay = 0.001f;
    //public Animator animator;
    public Queue<DialogueBase.Info> dialogueInfo = new Queue<DialogueBase.Info>(); //FIFO Collection


    private bool isCurrentlyTyping;
    private string completeText;

    private void Start()
    {
        dialogueInfo = new Queue<DialogueBase.Info>();
        //dialoguePanel.SetActive(false);
    }


    public void EnqueueDialogue(DialogueBase db)
    {
        //dialoguePanel.SetActive(true);
        //animator.SetBool("IsOpen", true);

        dialogueInfo.Clear();

        foreach (DialogueBase.Info info in db.dialogueInfo)
        {
            dialogueInfo.Enqueue(info);
        }

        DequeueDialogue();
    }

    public void DequeueDialogue()
    {
        if(isCurrentlyTyping == true)
        {
            CompleteText();
            StopAllCoroutines();
            isCurrentlyTyping = false;
            return;
        }
        
        //add code that detects if there are no more dialogue
        if (dialogueInfo.Count == 0)
        {
            EndDialogue();
            return;
        }

        

        DialogueBase.Info info = dialogueInfo.Dequeue();
        completeText = info.myText;

        dialogueName.text = info.myName;
        dialogueText.text = info.myText;
        dialoguePortrait.sprite = info.portrait;

        dialogueText.text = "";
        StartCoroutine(TypeText(info));
    }


    IEnumerator TypeText(DialogueBase.Info info)
    {
        isCurrentlyTyping = true;
        //dialogueText.text = "";
        foreach (char c in info.myText.ToCharArray())
        {
            yield return new WaitForSeconds(delay);
            dialogueText.text += c;
            //yield return null;
        }
        isCurrentlyTyping = false;
    }


    private void CompleteText()
    {
        dialogueText.text =  completeText;
    }


    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        //animator.SetBool("IsOpen", false);
    }
}