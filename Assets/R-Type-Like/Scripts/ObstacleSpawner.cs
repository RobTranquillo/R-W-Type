using System.Collections.Generic;
using System.Drawing.Printing;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnBaseDelay = 1f;
    public GameObject obstacle;
    public int maxCount;

    int visibleObs = 0;

    PlayerPointsData playerPointsData;

    private void Start()
    {
        playerPointsData = FindObjectOfType<PlayerPointsData>();

        Invoke("SpawnObstacle", NextSpanTime());
    }

    private float NextSpanTime()
    {
        return Random.Range(spawnBaseDelay/2, spawnBaseDelay);
    }

    private void SpawnObstacle()
    {
        if (visibleObs < maxCount)
            SpawnNewObstacle();
        Invoke("SpawnObstacle", NextSpanTime());
    }

    private void SpawnNewObstacle()
    {
        GameObject newObs = Instantiate(obstacle, transform);
        visibleObs++;
        SelfDestroyAtDistance selfDestroy = newObs.GetComponent<SelfDestroyAtDistance>();
        selfDestroy.onDestroy += () => { visibleObs--; };

        selfDestroy.onDestroy += () => { playerPointsData.ChangePoints(newObs.GetComponent<Points>().value); };
        
    }
}
