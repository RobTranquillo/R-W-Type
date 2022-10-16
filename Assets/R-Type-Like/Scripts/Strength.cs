using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    [Header("How many hits can get this")]

    public float strength = 100f;
    public bool selfDestroyOnZero = true;
    internal Action onDestroy;


    internal void Damage(float damageStrengthOnEnemies)
    {
        strength -= damageStrengthOnEnemies;
        if (strength > 0)
            return;
        if (!selfDestroyOnZero)
            return;
        onDestroy?.Invoke();
        Destroy(gameObject);
    }
}
