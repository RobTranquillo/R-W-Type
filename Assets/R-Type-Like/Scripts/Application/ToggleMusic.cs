using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToggleMusic : MonoBehaviour, IPointerUpHandler
{
    public GameObject checkmark;
    private bool isOn;

    MusicPlayer musicPlayer;

    private void Start()
    {
        isOn = checkmark.activeSelf;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isOn = !isOn;
        checkmark.SetActive(isOn);
        Toggle();
    }

    public void Toggle()
    {
        if (musicPlayer != null)
            musicPlayer = FindObjectOfType<MusicPlayer>();
        musicPlayer.gameObject.SetActive(isOn);
    }
}
