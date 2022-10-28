using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyGun : MonoBehaviour
{
    public float damageStrengthOnPlayer = 20f;
    public GameObject spark;
    public ParticleSystem particleSysGun;
    public AudioClip fireSound;


    private AudioSource audioSource;
    private List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = fireSound;
    }


    private void OnParticleCollision(GameObject other)
    {
        int eventCount = particleSysGun.GetCollisionEvents(other, collisionEvents);
        for (int i = 0; i < eventCount; i++)
            Instantiate(spark, collisionEvents[i].intersection, Quaternion.LookRotation(collisionEvents[i].normal));

        if (other.tag != "Player")
            return;
        other.GetComponent<HitDetector>().OnHitWithDamage(damageStrengthOnPlayer);
    }
}
