using System;
using TMPro;
using UnityEngine;

public class UpdateHealth : MonoBehaviour
{
    public TMP_Text m_Text;

    private void Awake()
    {
        PlayerHealthData phc = FindObjectOfType<PlayerHealthData>();
        phc.PlayerHealthChange += UpdateDisplay;
    }

    private void UpdateDisplay(float value)
    {
        if (value < 0) 
            value = 0;
        m_Text.text = value.ToString() + "%";
    }
}
