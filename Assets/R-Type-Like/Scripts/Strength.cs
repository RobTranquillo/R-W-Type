using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    [Header("How many hits can get this")]

    public float strength = 100f;
    public bool selfDestroyOnZero = true;
    public AudioClip soundIfDestroyed;

    internal Action onDestroy;
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponentInParent<AudioSource>();
        audioSource.loop = false;
        audioSource.clip = soundIfDestroyed;
    }

    internal void Damage(float damageStrengthOnEnemies)
    {
        strength -= damageStrengthOnEnemies;
        if (strength > 0)
            return;
        if (!selfDestroyOnZero)
            return;

        audioSource.Play();
        onDestroy?.Invoke();
        Destroy(gameObject);
    }
}
