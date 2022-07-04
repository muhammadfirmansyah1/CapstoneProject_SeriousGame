using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    
    #region Singleton:Shop
    public static Shop Instance;
    private void Awake() 
    {
        if (Instance == null)
        Instance = this;
        else
        Destroy(gameObject);    
    }
    #endregion

    [System.Serializable] public class ShopItem
    {
        public Sprite Image;
        public int Price;
        public string weaponName;
        public bool IsPurchased = false;
    }

    public List<ShopItem> ShopItemsList;
    [SerializeField] Animator NoCoinsAnim;
    //[SerializeField] Text CoinsText;


    GameObject ItemTemplate;
    GameObject g;
    [SerializeField] Transform ShopScrollView;
    Button buyBtn;

    void Start()
    {
        ItemTemplate = ShopScrollView.GetChild(0).gameObject;

        int len = ShopItemsList.Count;
        for (int i = 0; i < len; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
            g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemsList[i].Image;
            g.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Text>().text = ShopItemsList[i].Price.ToString();
            g.transform.GetChild(1).GetComponent<Text>().text = ShopItemsList[i].weaponName;
            buyBtn = g.transform.GetChild(2).GetComponent<Button>();
            buyBtn.interactable = !ShopItemsList [i].IsPurchased;
            buyBtn.AddEventListener (i, OnShopItemBtnClicked);


            //g.transform.GetChild(2).GetComponent<Button>().interactable = !ShopItemsList[i].IsPurchased;
        }

        Destroy(ItemTemplate);

        //Game.Instance.UpdateAllCoinsUIText();
        //SetCoinsUI();
    }

    void OnShopItemBtnClicked(int itemIndex)
    {
        if (Game.Instance.HasEnoughCoins (ShopItemsList[itemIndex].Price))
        {
            Game.Instance.UseCoins(ShopItemsList[itemIndex].Price);
            //Debug.Log(itemIndex);
            //purchase item
             ShopItemsList[itemIndex].IsPurchased = true;
            //disable the button
             //buyBtn.transform.GetChild(0).GetComponent <Text>().text = "DIBELI";
             ShopScrollView.GetChild(itemIndex).GetChild (2).GetComponent <Button> ().interactable = false;

            //change ui text: coins
            //SetCoinsUI();
            Game.Instance.UpdateAllCoinsUIText();
        }

        else
        {
            NoCoinsAnim.SetTrigger("NoCoins");
            Debug.Log ("Koin tidak cukup!");
        }
    }

    //shop coins UI
    /*void SetCoinsUI ()
    {
        CoinsText.text = Game.Instance.Coins.ToString();
    }*/


    //OPEN CLOSE SHOP

    public void OpenShop()
    {
        gameObject.SetActive (true);
    }

    public void CloseShop()
    {
        gameObject.SetActive (false);
    }
}
