using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    public float maxVertical = 40f;

    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-maxVertical, maxVertical), 0);
    }
}
