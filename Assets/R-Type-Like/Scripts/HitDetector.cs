using System;
using UnityEngine;

/// <summary>
/// Handle if somthing hits the player
/// </summary>
public class HitDetector : MonoBehaviour
{
    public float EnemiesDamageOnCollisison = 1000f;
    internal Action<float> OnHitWithDamage;

    PowerUpHandler powerUpHandler;

    private void Start()
    {
        powerUpHandler = GetComponentInParent<PowerUpHandler>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            OnHitWithDamage(collision.gameObject.GetComponent<Damage>().value);
            DisableRewardForOtherObject(collision.collider);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            // Damage on me
            OnHitWithDamage(collision.gameObject.GetComponentInParent<Damage>().value);
            // Damage on the enemy
            collision.gameObject.GetComponentInParent<Strength>().Damage(EnemiesDamageOnCollisison);
        }


        if (collision.gameObject.tag == "PowerUp")
        {
            powerUpHandler.Switch(collision.gameObject.GetComponentInParent<PowerUp>());
            Destroy(collision.gameObject);
        }
    }

    private void DisableRewardForOtherObject(Collider other)
    {
        other.GetComponent<Score>().DisableReward();
    }
}
