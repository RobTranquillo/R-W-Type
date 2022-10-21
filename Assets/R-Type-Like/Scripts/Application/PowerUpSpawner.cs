using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUps;

    private float intervall;
    void Start()
    {
        intervall = Settings.Active().PowerUpSpawner.BaseSpawnIntervall;
        Invoke("NextPowerUp", NextSpanTime());
    }

    private void NextPowerUp()
    {
        Instantiate(powerUps[Random.Range(0, powerUps.Length -1)], transform);
        Invoke("NextPowerUp", NextSpanTime());
    }

    private float NextSpanTime()
    {
        return Random.Range(intervall-(intervall/4), intervall+(intervall/4));
    }
}
