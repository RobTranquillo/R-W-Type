using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Hold the information how many points the player earns if survive this thing
/// </summary>
public class Points : MonoBehaviour
{
    [Header("Points the Player earns on survive this")]
    [SerializeField]
    private float value = 100f;

    public float Get()
    {
        return value;
    }

    public void DisableReward()
    {
        value = 0;
    }
}
