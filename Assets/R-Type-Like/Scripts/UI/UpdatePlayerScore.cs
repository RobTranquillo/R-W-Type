using System;
using TMPro;
using UnityEngine;

public class UpdatePlayerScore : MonoBehaviour
{
    public TMP_Text m_text;

    PlayerScoreData playerScoreData;
    private bool stopped = false;

    private void Start()
    {
        playerScoreData = FindObjectOfType<PlayerScoreData>();
        playerScoreData.OnPlayerScoreChange += UpdateDisplay;

        PlayerHealthData phc = FindObjectOfType<PlayerHealthData>();
        phc.PlayerHealthChange += StopOnGameOver;
    }

    private void StopOnGameOver(float health)
    {
        if (health < 1)
            stopped = true;
    }

    public void UpdateDisplay(float value)
    {
        if (stopped) 
            return;
        m_text.text = value.ToString();
    }
}
