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
        m_Text.text = value.ToString() + "%";
    }
}
