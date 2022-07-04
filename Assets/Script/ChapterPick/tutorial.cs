using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    public GameObject[] panelTutorial;
    int index;
    public int indexMax = 11;

    public GameObject[] buttonManager;

    // Start is called before the first frame update
    void Start()
    {
        panelTutorial[0].SetActive(false);
        index = 0;
        for (int i = 1; i < panelTutorial.Length; i++)
        {
            panelTutorial[i].gameObject.SetActive(false);
        }

       
    }

  // Update is called once per frame
    void Update()
    {
        

        if(index >= indexMax)
        {

            index = indexMax;
            //buttonManager[0].gameObject.SetActive(false);
        }


        if (index < indexMax && index >= 0) 
        {
            //buttonManager[0].gameObject.SetActive(true);
        }

        if(index <0)
        {
            index = 0;
          /*  for (int i = 0; i < panelTutorial.Length; i++)
            { 
             panelTutorial[i].gameObject.SetActive(false);
             
            } */
            panelTutorial[0].gameObject.SetActive(true);
            for (int j = 0; j < buttonManager.Length; j++)
            {
                buttonManager[j].gameObject.SetActive(true);
            }

        }

        if(index == 0)
        {
            //buttonManager[1].gameObject.SetActive(false);
        }

        if(index > 0)
        {
            //buttonManager[1].gameObject.SetActive(true);
        }
       

    }

    public void Next()
    {
        index += 1;
        for(int i = 0; i < panelTutorial.Length; i++)
        {
            panelTutorial[i].gameObject.SetActive(false);
            panelTutorial[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }

    public void Previous()
    {
        index -= 1;
        for (int i = 0; i < panelTutorial.Length; i++)
        {
            panelTutorial[i].gameObject.SetActive(false);
            panelTutorial[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }

    public void LoadDungeon()
    {
        for (int i = 0; i < panelTutorial.Length; i++)
        {
            panelTutorial[i].gameObject.SetActive(false);
            Debug.Log("berhasil");
        }

        buttonManager[0].gameObject.SetActive(false);
        buttonManager[1].gameObject.SetActive(false);
        buttonManager[2].gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
          /*  for (int i = 0; i < panelTutorial.Length; i++)
            {
                
                Debug.Log("berhasil");
            } */
            panelTutorial[0].gameObject.SetActive(true);
            buttonManager[0].gameObject.SetActive(true);
            buttonManager[1].gameObject.SetActive(true);
            buttonManager[2].gameObject.SetActive(true);
        }
        
    }
}
