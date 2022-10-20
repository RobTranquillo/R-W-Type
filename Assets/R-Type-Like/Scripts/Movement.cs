using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movingSpeed;

    public float rotatingTime = 5f;
    [Range(0, 180)]
    public float rotationX_Axis;
    [Range(0, 180)]
    public float rotationY_Axis;
    [Range(0, 180)]
    public float rotationZ_Axis;

    void FixedUpdate()
    {
        transform.position = transform.position + Vector3.left * movingSpeed;
    }

    private void Start()
    {
        if ((rotationX_Axis + rotationY_Axis + rotationZ_Axis + rotatingTime) == 0)
            return;
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        float timeElapsed = 0;
        Quaternion startRotation = transform.rotation;
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(rotationX_Axis, rotationY_Axis, rotationZ_Axis);
        while (timeElapsed < rotatingTime)
        {
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, timeElapsed / rotatingTime);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.rotation = targetRotation;
        StartCoroutine(Rotate());
    }
}
