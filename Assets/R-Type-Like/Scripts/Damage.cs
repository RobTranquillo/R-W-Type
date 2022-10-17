using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds the information how many damage the player get by this
/// </summary>
public class Damage : MonoBehaviour
{
    [Header("Damage the player appears on collsion")]
    public float value = 10f;

    [Header("Enemy Mesh")]
    public bool setupColliderInSubMeshes  = true;

    private void Start()
    {
        if (!setupColliderInSubMeshes)
            return;
        MeshCollider[] colliders = GetComponentsInChildren<MeshCollider>();
        foreach (MeshCollider coll in colliders)
            coll.isTrigger = coll.convex = true;
    }
}
