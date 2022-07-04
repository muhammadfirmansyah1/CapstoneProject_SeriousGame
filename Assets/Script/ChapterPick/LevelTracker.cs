using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTracker : MonoBehaviour
{
    //public static LevelTracker instance;
    public Sprite[] bg_TangkapBuah;
    public GameObject bg;

   /* private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
  */  


    void Start()
    {
        if(PickChapter1.instance.ch_TB1 == true)
        {
            bg.GetComponent<Image>().sprite = bg_TangkapBuah[0];
        } 
        else if(PickChapter1.instance.ch_TB2 == true)
        {
            bg.GetComponent<Image>().sprite = bg_TangkapBuah[1];
        }
        else if (PickChapter1.instance.ch_TB3 == true)
        {
            bg.GetComponent<Image>().sprite = bg_TangkapBuah[2];
        }
        else if (PickChapter1.instance.ch_TB4 == true)
        {
            bg.GetComponent<Image>().sprite = bg_TangkapBuah[3];
        }
        else if (PickChapter1.instance.ch_TB5 == true)
        {
            bg.GetComponent<Image>().sprite = bg_TangkapBuah[4];
        }
    }

    
    void Update()
    {
        
    }
}
