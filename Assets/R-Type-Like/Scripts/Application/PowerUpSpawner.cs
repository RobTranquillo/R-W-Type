using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUps;
    public float baseSpawnInterval = 13f;

    void Start()
    {
        Invoke("NextPowerUp", NextSpanTime());
    }

    private void NextPowerUp()
    {
        Instantiate(powerUps[Random.Range(0, powerUps.Length -1)], transform);
        Invoke("NextPowerUp", NextSpanTime());
    }

    private float NextSpanTime()
    {
        return Random.Range(baseSpawnInterval-(baseSpawnInterval/4), baseSpawnInterval+(baseSpawnInterval/4));
    }
}
