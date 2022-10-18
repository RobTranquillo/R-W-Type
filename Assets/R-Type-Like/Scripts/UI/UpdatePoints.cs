using System;
using TMPro;
using UnityEngine;

public class UpdatePoints : MonoBehaviour
{
    public TMP_Text m_text;

    PlayerPointsData playerPointsData;
    private bool stopped = false;

    private void Start()
    {
        playerPointsData = FindObjectOfType<PlayerPointsData>();
        playerPointsData.OnPlayerPointsChange += UpdateDisplay;

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
