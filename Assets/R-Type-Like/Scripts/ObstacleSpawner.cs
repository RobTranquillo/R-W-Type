using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnBaseDelay = 1f;
    public GameObject obstacle;
    public int maxCount;

    int visibleObs = 0;

    private void Start()
    {
        Invoke("SpawnObstacle", NextSpanTime());
    }

    private float NextSpanTime()
    {
        return Random.Range(spawnBaseDelay/2, spawnBaseDelay);
    }

    private void SpawnObstacle()
    {
        Debug.Log($"visibleObs.Count: {visibleObs}");
        if (visibleObs < maxCount)
            SpawnNewObstacle();
        Invoke("SpawnObstacle", NextSpanTime());
    }

    private void SpawnNewObstacle()
    {
        GameObject newObs = Instantiate(obstacle, transform);
        visibleObs++;
        newObs.GetComponent<SelfDestroy>().onDestroy += () => { visibleObs--; };
    }
}
