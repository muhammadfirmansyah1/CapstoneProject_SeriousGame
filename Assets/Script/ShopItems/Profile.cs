using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    /*
    #region Singleton:Profile
    public static Profile Instance;
    private void Awake() 
    {
        if (Instance == null)
        Instance = this;
        else
        Destroy(gameObject);    
    }
    #endregion

    public class Avatar
    {
        public Sprite Image;
    }

    public List<Avatar> AvatarsList;

    [SerializeField] GameObject AvatarUITemplate;
    [SerializeField] Transform AvatarsScrollView;

    GameObject g;

    private void Start() 
    {
        GetAvailableAvatars();   
    }

    private void GetAvailableAvatars()
    {
        for (int i = 0; i < Shop.Instance.ShopItemsList.Count; i++)
        {
            if (Shop.Instance.ShopItemsList[i].IsPurchased)
            {
                //add all purchased avatars to AvatarsList
                AddAvatar(Shop.Instance.ShopItemsList[i].Image);
            }
        }
    }

    void AddAvatar(Sprite img)
    {
        if (AvatarsList == null)
        AvatarsList = new List<Avatar> ();

        Avatar av = new Avatar(){Image = img};
        //add av to AvatarsList
        AvatarsList.Add (av);

        //add avatar in the UI scroll view
        g = Instantiate(AvatarUITemplate, AvatarsScrollView);
        g.transform.GetChild(0).GetComponent <Image>().sprite = av.Image;

    }
    */
}
