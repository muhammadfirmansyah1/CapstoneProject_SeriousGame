using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagertoOtherScene : MonoBehaviour
{
    public GameObject PaneltoMainMenu;

    //public Animator animTransition;
    // Start is called before the first frame update
    void Start()
    {
        PaneltoMainMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPanelToMainMenu()
    {
        PaneltoMainMenu.gameObject.SetActive(true);
    }

    public void ClosePanelToMainMenu()
    {
        PaneltoMainMenu.gameObject.SetActive(false);
    }

    public void MainMenu()
    {
        //animTransition.SetTrigger("Start");
        SceneManager.LoadScene(1);
    }

    public void PergikeTangkapBuah()
    {
        SceneManager.LoadScene("StackBuilding");
    }


}
