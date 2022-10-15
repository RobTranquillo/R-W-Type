using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 direction = new Vector3(-1,0,0);
        transform.position = transform.position + direction * speed;
    }
}
