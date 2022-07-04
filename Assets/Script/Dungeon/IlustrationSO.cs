using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Quiz Ilustartion", fileName = "New Ilustartion")]
public class IlustrationSO : ScriptableObject
{
    [TextArea(2,6)]
    public string explanation = "Enter new explanation text here";
    public string title = "ENter new Title text here";
    public Sprite imageExp;

    public string GetExplanation()
    {
        return explanation;
    }

    public string GetTitle()
    {
        return title;
    }
}
