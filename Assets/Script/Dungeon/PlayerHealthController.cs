using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    public int currentHealth;
    public int maxHealth;

    public float damageInvincibleLenght = 1f;
    public float invinCount;

    public Slider healthSlider;






    private void Awake() {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            return;
        }
        

        currentHealth = maxHealth;

        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Dungeon"))
        {
               // UIController.instance.healthSlider.maxValue = maxHealth;
               //UIController.instance.healthSlider.value= currentHealth;
            healthSlider.maxValue = maxHealth; 
            healthSlider.value = currentHealth;
              //  UIController.instance.healthText.text = currentHealth.ToString() + " / " + maxHealth.ToString();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(invinCount>0)
        {
            invinCount -= Time.deltaTime;

            if(invinCount <=0)
            {
                PlayerController.instance.bodySR.color = new Color(PlayerController.instance.bodySR.color.r, PlayerController.instance.bodySR.color.g, PlayerController.instance.bodySR.color.b, 1f);
            }
        }
        
    }

    public void DamagePlayer()
    {
        if(invinCount <= 0)
        {
        AudioManager.instance.PlaySFX(11);
        currentHealth--;
        invinCount = damageInvincibleLenght;

        PlayerController.instance.bodySR.color = new Color(PlayerController.instance.bodySR.color.r, 
            PlayerController.instance.bodySR.color.g, PlayerController.instance.bodySR.color.b, .5f);
        

        if(currentHealth <= 0)
        {
            PlayerController.instance.gameObject.SetActive(false);
            UIController.instance.deathScreen.SetActive(true);

            AudioManager.instance.PlayGameOver();
            AudioManager.instance.PlaySFX(9);
        }
            //UIController.instance.healthSlider.value= currentHealth;
            healthSlider.value = currentHealth;
            // UIController.instance.healthText.text = currentHealth.ToString() + " / " + maxHealth.ToString();
        }
    }

    public void MakeInvincible(float length)
    {
        invinCount = length;
        PlayerController.instance.bodySR.color = new Color(PlayerController.instance.bodySR.color.r, 
            PlayerController.instance.bodySR.color.g, PlayerController.instance.bodySR.color.b, .5f);
        
    }

    public void HealPlayer(int healAmount)
    {
        currentHealth += healAmount;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
       //UIController.instance.healthSlider.value= currentHealth;
        healthSlider.value = currentHealth;
        //UIController.instance.healthText.text = currentHealth.ToString() + " / " + maxHealth.ToString();
    }
}
