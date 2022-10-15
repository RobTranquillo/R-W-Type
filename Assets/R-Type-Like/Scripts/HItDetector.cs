using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    public Action<float> OnHitWithDamage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            OnHitWithDamage(other.GetComponent<Damage>().value);
            DisableRewardForOtherObject(other);
        }
    }

    private void DisableRewardForOtherObject(Collider other)
    {
        other.GetComponent<Points>().DisableReward();
    }
}
