using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestforEduc : MonoBehaviour
{
    public GameObject ChestPanel;

    [Header("Question")]
    [SerializeField] Text explanationText;
    [SerializeField] Text titleText;
    [SerializeField] GameObject imageExplanation;
    [SerializeField] public IlustrationSO explanationFull;
    public bool hasCollectCoin;
    IlustrationSO currentExplanation;

    void Awake()
    {
        ChestPanel.SetActive(false);
        //currentExplanation = FindObjectOfType<IlustrationSO>();
        //explanationFull = FindObjectOfType<IlustrationSO>();

        hasCollectCoin = true;

        explanationText.text = explanationFull.GetExplanation();
        titleText.text = explanationFull.GetTitle();
        imageExplanation.GetComponent<Image>().sprite = explanationFull.imageExp;
    }

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }

    public void DisplayTitleExplanationImage()
    {
       explanationText.text = currentExplanation.explanation;
       titleText.text = currentExplanation.title;
       imageExplanation.GetComponent<Image>().sprite = currentExplanation.imageExp;
    } 

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            
            //LevelManager.instance.GetCoins(coinValue);
            //Destroy(gameObject);
            ChestPanel.SetActive(true);
            AudioManager.instance.PlaySFX(20);
            if(hasCollectCoin == true)
            {
                LevelManager.instance.GetCoins(1);
                AudioManager.instance.PlaySFX(5);
                hasCollectCoin = false;
            } 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            //LevelManager.instance.GetCoins(coinValue);
            //Destroy(gameObject);
            ChestPanel.SetActive(true);
        }
    }

    public void NextButton()
    {
        ChestPanel.SetActive(false);
    }
}
