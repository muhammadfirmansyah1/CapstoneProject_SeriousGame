using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senjata : MonoBehaviour
{
    [System.Serializable]
    class Weapon
    {
        public Sprite Image;
        public int Price;
        public string weaponName;
        public int attack;
        public int hp;
        public bool IsPurchased = false;
    }


}
