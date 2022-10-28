using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject boss;
    
    private PlayerPointsData playerPointsData;
    private GameObject bossGO = null;
    

    void Start()
    {
        playerPointsData = FindObjectOfType<PlayerPointsData>();
        Invoke("SpawnEnemy", NextSpanTime());
    }

    private float NextSpanTime()
    {
        if (!Settings.Active().EnemySpawner.increaseEnemyCount)
            return Random.Range(Settings.Active().EnemySpawner.spawnBaseIntervall / 2, Settings.Active().EnemySpawner.spawnBaseIntervall);

        if (Time.time > Settings.Active().EnemySpawner.waveLength)
            Invoke("StartBoss", 7f);


        //nach vergangene Zeit/30 wird der respawn Interval bis auf minimal alle 0.7 Sekunden runtergeschraubt
        return Mathf.Clamp(Settings.Active().EnemySpawner.spawnBaseIntervall - Time.realtimeSinceStartup/30, 0.7f, 100f);
    }

    private void StartBoss()
    {   
        if (bossGO == null)
            bossGO = Instantiate(boss, transform);
    }

    void SpawnEnemy()
    {
        if (bossGO != null)
            return;
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
