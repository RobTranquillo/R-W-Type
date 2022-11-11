using UnityEditor;
using UnityEngine;

public class BuildVersion : MonoBehaviour
{
    private void Awake()
    {
        if (TryGetComponent(out TMPro.TMP_Text output))
            output.text = $"Build: { PlayerSettings.bundleVersion}";
    }
} 
