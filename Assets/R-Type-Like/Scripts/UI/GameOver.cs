using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TMP_Text text;

    private void Start()
    {
        text.enabled = false;
    }

    internal void Display()
    {
        text.enabled = true;
    }
}
