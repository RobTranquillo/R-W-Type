using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "BuildVersion", menuName = "R-W-Type/Build Version", order = 1)]
public class Version : ScriptableObject
{
    public int major = 0;
    public int minor = 0;
    private string _value;
    
    public string Get()
    {
        _value = $"[{major}.{minor}] - {DateTime.Now.ToString("d")}";
        return _value;
    }
}
