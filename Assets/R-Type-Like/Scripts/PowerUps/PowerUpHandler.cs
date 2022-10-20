using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PowerUpItem
{
    None = 0,
    StandardGun = 1000,
    TrippleGun = 1001,
}

public class PowerUpHandler : MonoBehaviour
{
    public GameObject standardGun;
    private GameObject lastActivePowerUp;
  
    internal void Switch(PowerUp nextPowerUp)
    {
        if (lastActivePowerUp != null)
            Destroy(lastActivePowerUp);
        lastActivePowerUp = Instantiate(nextPowerUp.prefab, transform);
        lastActivePowerUp.SetActive(true);
        StartCoroutine(ResetToStandardGun(nextPowerUp.duration));
    }

    private IEnumerator ResetToStandardGun(float duration)
    {
        yield return new WaitForSeconds(duration);
        if (lastActivePowerUp == standardGun)
            yield return null;
        if (lastActivePowerUp != null)
            Destroy(lastActivePowerUp);
    }

    private void Start()
    {
    }
}
