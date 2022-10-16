using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float spawnBaseDelay = 1f;
    public int maxCount = 5;

    int visibleEnemies = 0;
    PlayerPointsData playerPointsData;

    void Start()
    {
        playerPointsData = FindObjectOfType<PlayerPointsData>();
        Invoke("SpawnEnemy", NextSpanTime());
    }

    private float NextSpanTime()
    {
        return Random.Range(spawnBaseDelay / 8, spawnBaseDelay);
    }

    void SpawnEnemy()
    {
        if (visibleEnemies < maxCount)
            SpawnNewEnemy();
        Invoke("SpawnEnemy", NextSpanTime());
    }

    private void SpawnNewEnemy()
    {
        GameObject newEnemy = Instantiate(enemies[Random.Range(0,2)], transform);
        visibleEnemies++;

        //todo: unterschiedliche Werte für abschießen und einfach nur ausgewichen
        float yield = newEnemy.GetComponent<Points>().Get();

        SelfDestroyAtDistance selfDestroy = newEnemy.GetComponent<SelfDestroyAtDistance>();
        selfDestroy.onDestroy += () => { visibleEnemies--; };
        selfDestroy.onDestroy += () => { playerPointsData.ChangePoints(yield); };

        Strength strength = newEnemy.GetComponent<Strength>();
        strength.onDestroy += () => { visibleEnemies--; };
        strength.onDestroy += () => { playerPointsData.ChangePoints(yield); };

    }
}
