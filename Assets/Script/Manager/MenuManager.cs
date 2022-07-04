using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator animTransition;
    public GameObject transition;
    // Start is called before the first frame update
    void Start()
    {
        transition.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        animTransition.SetTrigger("Start");
       // yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("Dungeon");
    }

    public void LoadPlayerStats()
    {
        animTransition.SetTrigger("Start");
       // yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("Stats&ScorePlayer");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("berhasil");
    }

    public void BacktoMenu()
    {
        animTransition.SetTrigger("Start");
        SceneManager.LoadScene("MainMenu");
    }
}
