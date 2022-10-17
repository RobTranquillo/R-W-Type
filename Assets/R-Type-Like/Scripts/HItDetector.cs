using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    public float EnemiesDamageOnCollisison = 1000f;
    internal Action<float> OnHitWithDamage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            OnHitWithDamage(other.GetComponent<Damage>().value);
            DisableRewardForOtherObject(other);
        }

        if (other.tag == "Enemy")
        { 
            // Damage on me
            OnHitWithDamage(other.GetComponentInParent<Damage>().value);
            // Damage on the enemy
            other.GetComponentInParent<Strength>().Damage(EnemiesDamageOnCollisison);
        }
    }

    private void DisableRewardForOtherObject(Collider other)
    {
        other.GetComponent<Points>().DisableReward();
    }
}
