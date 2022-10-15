using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointsData : MonoBehaviour
{
    float points = 0f;

    public Action<float> OnPlayerPointsChange;

    /// <summary>
    /// Change the value of the points by the given value.
    /// </summary>
    /// <param name="difference"></param>
    public void ChangePoints(float difference)
    {
        points += difference;
        OnPlayerPointsChange(points);
    }

    public float Points()
    {
        return points;
    }
}
