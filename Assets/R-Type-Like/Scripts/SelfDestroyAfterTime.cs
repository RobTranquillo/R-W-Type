using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyAfterTime : MonoBehaviour
{
    internal Action onDestroy;
    public float delay = 2f;
    float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (startTime + delay > Time.time)
            return;
        onDestroy?.Invoke();
        Destroy(this.gameObject);
    }
}
