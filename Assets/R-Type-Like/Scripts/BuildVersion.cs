using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BuildVersion : MonoBehaviour
{
    public Version version;

    private void Awake()
    {
        if (TryGetComponent(out TMPro.TMP_Text output))
            output.text = $"Build: { version.Get() }";
    }
}
