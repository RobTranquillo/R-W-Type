using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StandardGun : MonoBehaviour
{
    public float damageStrengthOnEnemies = 30f;
    public GameObject spark;
    private List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();
    public ParticleSystem particleSysGun;
    public ParticleSystem particleSysMuzzleFlare;


    private void OnParticleCollision(GameObject other)
    {
        int eventCount = particleSysGun.GetCollisionEvents(other, collisionEvents);
        for (int i = 0; i < eventCount; i++)
        {
            Instantiate(spark, collisionEvents[i].intersection, Quaternion.LookRotation(collisionEvents[i].normal));
        }

        if (other.tag != "Enemy")
            return;
        other.transform.parent.GetComponent<Strength>().Damage(damageStrengthOnEnemies);
    }

    private void FireStop(InputAction.CallbackContext obj)
    {
        particleSysMuzzleFlare.Stop();
        particleSysGun.Stop();
    }

    private void FireStart(InputAction.CallbackContext obj)
    {
        particleSysMuzzleFlare.Play();
        particleSysGun.Play();
    }

    #region - Input System -
    private InputKeyboard inputKeyboard;
    private void OnEnable()
    {
        inputKeyboard.ShipControl.Enable();
    }
    private void OnDisable()
    {
        inputKeyboard.ShipControl.Disable();
    }

    private void Awake()
    {
        inputKeyboard = new InputKeyboard();
        inputKeyboard.ShipControl.Fire.started  += FireStart;
        inputKeyboard.ShipControl.Fire.canceled += FireStop;
    }
    #endregion - Input System -
}
