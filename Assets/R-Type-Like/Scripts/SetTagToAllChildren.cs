using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTagToAllChildren : MonoBehaviour
{
    public string tagToBeSet = "Enemy";

    void Awake()
    {
        Transform[] allTr = GetComponentsInChildren<Transform>();

        foreach (Component tr in allTr)
            tr.tag = tagToBeSet;
    }
}
