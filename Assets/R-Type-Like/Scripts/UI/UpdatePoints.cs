using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdatePoints : MonoBehaviour
{
    public TMP_Text m_text;

    PlayerPointsData playerPointsData;

    private void Start()
    {
        playerPointsData = FindObjectOfType<PlayerPointsData>();
        playerPointsData.OnPlayerPointsChange += UpdateDisplay;
    }

    public void UpdateDisplay(float value)
    {
        m_text.text = value.ToString();
    }
}
