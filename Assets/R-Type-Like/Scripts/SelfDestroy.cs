using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    internal Action onDestroy;
    float selfDestroyX = -100f;

    void Update()
    {
        if (transform.position.x > selfDestroyX)
            return;
        Destroy(this.gameObject);
        onDestroy.Invoke();
    }
}
