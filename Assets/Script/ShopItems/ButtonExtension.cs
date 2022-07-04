using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class ButtonExtension //: MonoBehaviour
{
    public static void AddEventListener<T> (this Button button, T param, Action <T> OnClick)
    {
        button.onClick.AddListener(delegate()
        {
            OnClick (param);
        });
    }
}
