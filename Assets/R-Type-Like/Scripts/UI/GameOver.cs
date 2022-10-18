using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<PlayerHealthData>().PlayerHealthChange += ShowGameOver;
        gameObject.SetActive(false);
    }

    internal void ShowGameOver(float health)
    {
        if (health > 0)
            return;
        gameObject.SetActive(true);
    }
}
