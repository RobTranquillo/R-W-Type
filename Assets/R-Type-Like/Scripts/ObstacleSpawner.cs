using System.Collections.Generic;
using System.Drawing.Printing;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    int visibleObs = 0;
    PlayerPointsData playerPointsData;

    private void Start()
    {
        playerPointsData = FindObjectOfType<PlayerPointsData>();

        Invoke("SpawnObstacle", NextSpanTime());
    }

    private float NextSpanTime()
    {
        return Random.Range(Settings.Active().ObstacleSpawner.BaseSpawnIntervall / 2, Settings.Active().ObstacleSpawner.BaseSpawnIntervall);
    }

    private void SpawnObstacle()
    {
        if (visibleObs < Settings.Active().ObstacleSpawner.MaxCount)
            SpawnNewObstacle();
        Invoke("SpawnObstacle", NextSpanTime());
    }

    private void SpawnNewObstacle()
    {
        GameObject newObs = Instantiate(obstacle, transform);
        visibleObs++;
        SelfDestroyAtDistance selfDestroy = newObs.GetComponent<SelfDestroyAtDistance>();
        selfDestroy.onDestroy += () => { visibleObs--; };

        selfDestroy.onDestroy += () => { playerPointsData.ChangePoints(newObs.GetComponent<Points>().Get()); };
        
    }
}
