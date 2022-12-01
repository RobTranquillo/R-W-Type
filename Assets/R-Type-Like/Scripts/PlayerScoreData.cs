using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScoreData : MonoBehaviour
{
    public Action<float> OnPlayerScoreChange;

    private float score = 0f;
    private bool stopped = false;


    private void Start()
    {
        PlayerHealthData phc = FindObjectOfType<PlayerHealthData>();
        phc.PlayerHealthChange += StopOnGameOver;
    }

    /// <summary>
    /// Change the value of the points by the given value.
    /// </summary>
    /// <param name="difference"></param>
    public void ChangePoints(float difference)
    {
        if (stopped)
            return;
        score += difference;
        OnPlayerScoreChange(score);
    }

    public float Score()
    {
        return score;
    }

    private void StopOnGameOver(float health)
    {
        if (health < 1)
            stopped = true;
    }
}
