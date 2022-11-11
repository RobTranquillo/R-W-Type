using UnityEngine;
using UnityEngine.UI;

public class BuildVersion : MonoBehaviour
{
    private void Awake()
    {
        if (TryGetComponent(out TMPro.TMP_Text output))
            output.text = $"Build: { Application.version }";
    }
}
