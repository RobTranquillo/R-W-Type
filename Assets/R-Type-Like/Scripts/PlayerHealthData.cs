using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using UnityEngine;

public class PlayerHealthData : MonoBehaviour
{
    public float shipIntegrety = 100f;
    public AudioClip crashSound;
    public AudioClip dieSound;
    public AudioSource audioSource;

    public Action<float> PlayerHealthChange;
    HitDetector hitDetector;

    void Start()
    {
        hitDetector = GetComponentInChildren<HitDetector>();
        hitDetector.OnHitWithDamage = LowerShipIntegrety;
        if (PlayerHealthChange != null)
            PlayerHealthChange(shipIntegrety);
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();

    }

    private void LowerShipIntegrety(float value)
    {
        shipIntegrety -= value;
        if (PlayerHealthChange != null)
            PlayerHealthChange(shipIntegrety);
        audioSource.clip = crashSound;
        audioSource.Play();
        if (shipIntegrety > 0)
            return;

        Debug.Log("GAME OVER");
        audioSource.clip = dieSound;
        audioSource.Play();
        FindObjectOfType<MusicPlayer>()?.gameObject.SetActive(false);
        Destroy(gameObject);
    }    
}
