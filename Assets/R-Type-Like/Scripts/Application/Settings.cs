using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Settings : MonoBehaviour
{
    private static Settings Current { get; set; }

    public SettingsScriptableObject activeSettings;

    public SettingsScriptableObject[] availableSettings;

    private void Awake()
    {
        if (Current == null)
        {
            Current = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static SettingsScriptableObject Active()
    {
        return Current.activeSettings;
    }
}
