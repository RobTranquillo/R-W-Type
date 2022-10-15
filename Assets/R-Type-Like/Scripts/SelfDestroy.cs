using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    internal Action onDestroy;
    float selfDestroyPosition = -100f;

    void Update()
    {
        if (transform.position.x > selfDestroyPosition)
            return;
        onDestroy?.Invoke();
        Destroy(this.gameObject);
    }
}
