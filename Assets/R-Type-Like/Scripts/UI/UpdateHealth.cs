using System;
using TMPro;
using UnityEngine;

public class UpdateHealth : MonoBehaviour
{
    public TMP_Text m_Text;


    private void Start()
    {
        PlayerHealthController phc = FindObjectOfType<PlayerHealthController>();
        phc.PlayerHealthChange += UpdateDisplay;
    }

    private void UpdateDisplay(object sender, float value)
    {
        m_Text.text = value.ToString() + "%";
    }
}
