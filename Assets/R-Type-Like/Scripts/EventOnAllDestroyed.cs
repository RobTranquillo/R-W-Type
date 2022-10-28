using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class EventOnAllDestroyed : MonoBehaviour
{
    public Strength[] destroyables;
    public UnityEvent onAllDestroyed;

    private List<GameObject> destroyablesGameObjects = new List<GameObject>();

    void Start()
    {
        foreach (Strength obj in destroyables)
        {
            obj.onDestroy += markDestroyed;
            destroyablesGameObjects.Add(obj.gameObject);
        }
    }

    private void markDestroyed()
    {
        Strength[] surviver = destroyables.Where(obj => obj != null).ToArray();
        if (surviver.Length == 1)
            onAllDestroyed.Invoke();
    }
}
