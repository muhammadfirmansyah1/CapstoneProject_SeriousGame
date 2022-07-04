using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class MainMenu : MonoBehaviour
{
    [Header("Panel Peringatan")]
    public GameObject panelCaution;
    public GameObject panelCautionQuit;

    public Button button;

    bool IsitFirst = true;

    private void Start()
    {
        
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
            panelCautionQuit.gameObject.SetActive(false);
            panelCaution.gameObject.SetActive(false);
            // button.GetComponent<Button>().interactable = false;

            /*
            PlayerData data = SaveSystem.LoadPlayer();
            int scoreQuiz = data.scoreQuiz;

            string path = Application.persistentDataPath + "/Player.fun";
            if (File.Exists(path) == true)
            {
                button.GetComponent<Button>().interactable = true;
                Debug.Log("ada");
            /*    if (scoreQuiz < 1)
                {
                    button.GetComponent<Button>().interactable = false;

                } else if (scoreQuiz >= 1)
                {  
              
            }
            else
            {
                button.GetComponent<Button>().interactable = false;
                Debug.Log("gak ada");
            }    
            */


            
            if(IsitFirst == false)
            {
                button.GetComponent<Button>().interactable = true;
            } 
            else if (IsitFirst == true)
            {
                button.GetComponent<Button>().interactable = false;
            }
            
        }

    }

    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
                    PlayerData data = SaveSystem.LoadPlayer();
                    int scoreQuiz = data.scoreQuiz;
                    if(scoreQuiz >= 0)
                    {
                        IsitFirst = false;
                       if (IsitFirst == false)
                        {
                            button.GetComponent<Button>().interactable = true;
                        }
                        else if (IsitFirst == true)
                        {
                            button.GetComponent<Button>().interactable = false;
                       } 
                    }

        }
        
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayChapter()
    {
        SceneManager.LoadScene("Chapters");
    }

    public void OpenShop()
    {
        SceneManager.LoadScene("Toko");
    }

    public void NewGame()
    {
        panelCaution.gameObject.SetActive(true);
    }

    public void CloseCaution()
    {
        panelCaution.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void BeforeQuit()
    {
        panelCautionQuit.gameObject.SetActive(true);
    }
    public void CancelBeforeQuit()
    {
        panelCautionQuit.gameObject.SetActive(false);
    }
}
