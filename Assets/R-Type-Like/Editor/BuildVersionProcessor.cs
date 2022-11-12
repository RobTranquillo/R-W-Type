using UnityEngine;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using System;

public class BuildVersionProcessor : IPreprocessBuildWithReport
{
    public int callbackOrder => 0;
    private const string intialVersion = "0,0";


    public void OnPreprocessBuild(BuildReport report)
    {
        string currentVersion = FindCurrentVersion();
#if UNITY_EDITOR_WIN
        UpdateVersion(currentVersion);
#endif
    }

    private string FindCurrentVersion()
    {
        string[] currentVersion = Application.version.Split('[', ',', ']');

        return currentVersion.Length == 1 ? intialVersion : currentVersion[2];
    }

    private void UpdateVersion(string version)
    {
        if (int.TryParse(version, out int versionNumber))
        {
            string date = DateTime.Now.ToString("d");
            PlayerSettings.bundleVersion = $"Version [{versionNumber++}] - {date}";
        }
    }
}
