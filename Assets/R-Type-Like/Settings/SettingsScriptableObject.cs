using System;
using Unity.VisualScripting;
using UnityEngine;


/// <summary>
/// Singleton class to get acces to the active game settings
/// 
/// ! Can not use in Awake() ! Earliest access in Start() possible.
/// 
/// Structure:
/// ---------
/// Settings should be named as same as the class 
/// for what they are and also there properties
/// 
/// 
/// Usage:
/// -----
/// 
/// private void Start()
/// {
///     horizontalSpeed = SettingsController.Active().PlayerController.HorizontalSpeed;
///     verticalSpeed = SettingsController.Active().PlayerController.VerticalSpeed;
/// }
/// 
/// </summary>
[CreateAssetMenu(menuName = "R-W-Type/SettingsScriptableObject")]
public class SettingsScriptableObject : ScriptableObject
{
    [Serializable]
    public class PlayerControllerSettings
    {
        public float VerticalSpeed;
        public float HorizontalSpeed;
    }
    public SettingsScriptableObject.PlayerControllerSettings PlayerController;


    [Serializable]
    public class PlayerHealthSettings
    {
        public float ShoipIntegrity;
    }
    public SettingsScriptableObject.PlayerHealthSettings PlayerHealth;


    [Serializable]
    public class EnemySpawnerSettings
    {
        public float spawnBaseIntervall;
        public bool increaseEnemyCount;
        public float waveLength;
    }
    public SettingsScriptableObject.EnemySpawnerSettings EnemySpawner;
    
    [Serializable]
    public class ObstacleSpawnerSettings
    {
        public float BaseSpawnIntervall;
        public float MaxCount;
        public float MovingSpeedBase;
        public float MovingSpeedVariance;
    }
    public SettingsScriptableObject.ObstacleSpawnerSettings ObstacleSpawner;
    
    [Serializable]
    public class PowerUpSpawnerSettings
    {
        public float BaseSpawnIntervall;
    }
    public SettingsScriptableObject.PowerUpSpawnerSettings PowerUpSpawner;
    
    [Serializable]
    public class StandardGunSettings
    {
        public float DamageOnEnemies;
    }
    public SettingsScriptableObject.StandardGunSettings StandardGun;
    
    [Serializable]
    public class HitDetectorSettings
    {
        public float EnemiesDamageOnCollision;
    }
    public SettingsScriptableObject.HitDetectorSettings HitDetector;

}
