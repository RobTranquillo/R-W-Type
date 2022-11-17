using DG.Tweening;
using System;
using UnityEngine;


public class Strength : MonoBehaviour
{
    [Header("How many hits can get this")]

    public float strength = 100f;
    public bool selfDestroyOnZero = true;
    public AudioSource audioSource;
    public AudioClip soundIfDestroyed;
    public AudioClip soundOnHit;
    public GameObject destroyParticleSystem;

    [Header("Interims FX")]
    [Tooltip("Do not play hit sound on every hit, but on every X hit")]
    public int soundOnlyEveryXHit = 1;
    [Tooltip("Shake on every X hit")]
    public bool shakeRandomOnXHit = true;
    public bool rotateRandomOnXHit = true;
    public GameObject applyToObject;
    public float shakeDuration = 0.6f;
    public float shakeStrength = 0.6f;
    public int shakeVibratio = 10;
    public float shakeRandomness = 0.6f;
    public float destroyDelay = 0.3f;

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
        ShakeOnHit();
        strength -= damageStrengthOnEnemies;
        if (strength > 0)
            return;
        if (!selfDestroyOnZero)
            return;

        destroyParticleSystem.SetActive(true);
        audioSource.clip = soundIfDestroyed;
        audioSource.Play();
        onDestroy?.Invoke();
        Invoke("DestroyNow", destroyDelay);
    }

    private void DestroyNow()
    {
        Destroy(gameObject);
    }

    private void ShakeOnHit()
    {
        if (!shakeRandomOnXHit)
            return;
        applyToObject?.transform.DOShakePosition(shakeDuration, shakeStrength, shakeVibratio, shakeRandomness);
        if (!rotateRandomOnXHit)
            return;
        applyToObject?.transform.DOShakeRotation(shakeDuration, shakeStrength, shakeVibratio, shakeRandomness);
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
