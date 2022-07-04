using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    //public Slider healthSlider;
    public Text mask;
    public int maskValue;
    public Text healthText;
    public Text coinMC;
    public GameObject deathScreen;

    private void Awake() {
        instance= this;
        coinMC.text = LevelManager.instance.currentCoins.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
    }
          

    // Update is called once per frame
    void Update()
    {
        mask.text = LevelManager.instance.currentTimeforDash.ToString();
        coinMC.text = LevelManager.instance.currentCoins.ToString();

    }
}
