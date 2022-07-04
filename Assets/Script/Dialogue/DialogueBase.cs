using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class DialogueBase : ScriptableObject //MonoBehaviour
{
    [System.Serializable]
    public class Info
    {
        public string myName;
        public Sprite portrait;
        [TextArea(4, 8)]
        public string myText;
    }

    [Header("Insert Dialogue Information below")]
    public Info[] dialogueInfo;
}
