using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    [Header("How many hits can get this")]

    public float strength = 100f;
    public bool selfDestroyOnZero = true;
    public AudioSource audioSource;
    public AudioClip soundIfDestroyed;
    public AudioClip soundOnHit;
    [Tooltip("Do not play hit sound on every hit, but on every X hit")]
    public int soundOnlyEveryXHit = 1;

    internal Action onDestroy;
    internal int lastHits = 1;


    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponentInParent<AudioSource>();
        audioSource.loop = false;
        if (soundIfDestroyed == null)
            audioSource.clip = soundIfDestroyed;
    }

    internal void Damage(float damageStrengthOnEnemies)
    {
        SoundOnHit();
        strength -= damageStrengthOnEnemies;
        if (strength > 0)
            return;
        if (!selfDestroyOnZero)
            return;

        audioSource.clip = soundIfDestroyed;
        audioSource.Play();
        onDestroy?.Invoke();
        Destroy(gameObject);
    }

    private void SoundOnHit()
    {
        if (soundOnHit == null)
            return;

         if (soundOnlyEveryXHit != 1)
            lastHits++;

        if (lastHits < soundOnlyEveryXHit)
            return;

        lastHits = 1;

        audioSource.clip = soundOnHit;
        audioSource.Play();
    }
}
