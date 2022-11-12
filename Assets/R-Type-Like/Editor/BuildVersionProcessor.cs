using UnityEngine;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using System;

public class BuildVersionProcessor : IPreprocessBuildWithReport
{
    public int callbackOrder => 0;
    private const string intialVersion = "0.0";


    public void OnPreprocessBuild(BuildReport report)
    {
        string currentVersion = FindCurrentVersion();
#if UNITY_EDITOR_WIN
        UpdateVersion(currentVersion);
#endif
    }

    private string FindCurrentVersion()
    {
        string[] currentVersion = Application.version.Split('[', ']');

        return currentVersion.Length == 1 ? intialVersion : currentVersion[1];
    }

    private void UpdateVersion(string version)
    {
        version = version.Replace('.', ',');
        if (float.TryParse(version, out float versionNumber))
        {
            float newVersion = versionNumber + 0.01f;
            string date = DateTime.Now.ToString("d");
            PlayerSettings.bundleVersion = $"Version [{newVersion.ToString().Replace(',', '.')}] - {date}";
        }
    }
}
