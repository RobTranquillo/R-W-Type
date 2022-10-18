using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float spawnMaxNewEnemyDelay = 1f;

    int visibleEnemies = 0;
    PlayerPointsData playerPointsData;

    void Start()
    {
        playerPointsData = FindObjectOfType<PlayerPointsData>();
        Invoke("SpawnEnemy", NextSpanTime());
    }

    private float NextSpanTime()
    {
        return Random.Range(spawnMaxNewEnemyDelay / 2, spawnMaxNewEnemyDelay);
    }

    void SpawnEnemy()
    {
        SpawnNewEnemy();
        Invoke("SpawnEnemy", NextSpanTime());
    }

    private void SpawnNewEnemy()
    {
        GameObject newEnemy = Instantiate(enemies[Random.Range(0, enemies.Length)], transform);
        float yield = newEnemy.GetComponentInChildren<Points>().Get();

        SelfDestroyAtDistance selfDestroy = newEnemy.GetComponentInChildren<SelfDestroyAtDistance>();
        selfDestroy.onDestroy += () => { playerPointsData.ChangePoints(yield); };

        Strength strength = newEnemy.GetComponentInChildren<Strength>();
        strength.onDestroy += () => { playerPointsData.ChangePoints(yield); };
    }

}
