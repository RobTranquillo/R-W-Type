using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public float shipIntegrety = 100f;

    HitDetector hitDetector;
    public event EventHandler<float> PlayerHealthChange;

    void Start()
    {
        hitDetector = GetComponentInChildren<HitDetector>();
        hitDetector.OnHitWithDamage = LowerShipIntegrety;
    }

    private void LowerShipIntegrety(float value)
    {
        shipIntegrety -= value;
        PlayerHealthChange?.Invoke(this, shipIntegrety);
        Debug.Log($"shipIntegrety: {shipIntegrety}");
        if (shipIntegrety > 0)
            return;
        
        Debug.Log("GAME OVER");
        Destroy(gameObject);
    }
}
