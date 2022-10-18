using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using UnityEngine;

public class PlayerHealthData : MonoBehaviour
{
    public float shipIntegrety = 100f;

    public Action<float> PlayerHealthChange;
    HitDetector hitDetector;

    void Start()
    {
        hitDetector = GetComponentInChildren<HitDetector>();
        hitDetector.OnHitWithDamage = LowerShipIntegrety;
        PlayerHealthChange(shipIntegrety);
    }

    private void LowerShipIntegrety(float value)
    {
        shipIntegrety -= value;
        PlayerHealthChange(shipIntegrety);
        if (shipIntegrety > 0)
            return;
        
        Debug.Log("GAME OVER");
        Destroy(gameObject);
    }
}
