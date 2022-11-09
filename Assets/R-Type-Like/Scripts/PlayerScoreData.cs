using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreData : MonoBehaviour
{
    float score = 0f;

    public Action<float> OnPlayerScoreChange;

    /// <summary>
    /// Change the value of the points by the given value.
    /// </summary>
    /// <param name="difference"></param>
    public void ChangePoints(float difference)
    {
        score += difference;
        OnPlayerScoreChange(score);
    }

    public float Score()
    {
        return score;
    }
}
