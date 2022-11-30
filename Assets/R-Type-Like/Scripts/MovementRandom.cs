using System;
using System.Collections;
using UnityEngine;

public class MovementRandom : Movement
{    
    private void Start()
    {
        if ((rotationX_Axis + rotationY_Axis + rotationZ_Axis + rotatingTime) == 0)
            return;

        movingSpeed = UnityEngine.Random.Range(
            Settings.Active().ObstacleSpawner.MovingSpeedBase - Settings.Active().ObstacleSpawner.MovingSpeedVariance / 2,
            Settings.Active().ObstacleSpawner.MovingSpeedBase + Settings.Active().ObstacleSpawner.MovingSpeedVariance / 2
        );

        StartCoroutine(Rotate());
    }
}