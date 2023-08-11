using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace HealthAndDamageScalingPatcher;

public class Settings
{
    [MaintainOrder]
    [SettingName("Feature Health")]
    [Tooltip("Enables or disables health adjustments")]
    public bool FeatureHealth = false;
    
    [MaintainOrder]
    [SettingName("Health Min Target")]
    [Tooltip("This is what 'Health Min Guess' will become")]
    public float HealthMinTarget = 30f;
    
    [MaintainOrder]
    [SettingName("Health Max Target")]
    [Tooltip("This is what 'Health Max Guess' will become")]
    public float HealthMaxTarget = 100f;
    
    [MaintainOrder]
    [SettingName("Health Min Guess")]
    [Tooltip("Used by Health Min Target")]
    public float HealthMinGuess = 3f;
    
    [MaintainOrder]
    [SettingName("Health Max Guess")]
    [Tooltip("Used by Health Max Target")]
    public float HealthMaxGuess = 200f;
    
    [MaintainOrder]
    [SettingName("Melee Min Target")]
    [Tooltip("This is what 'Melee Min Guess' will become")]
    public float MeleeMinTarget = 15f;
    
    [MaintainOrder]
    [SettingName("Melee Max Target")]
    [Tooltip("This is what 'Melee Max Guess' will become")]
    public float MeleeMaxTarget = 30f;
    
    [MaintainOrder]
    [SettingName("Melee Min Guess")]
    [Tooltip("Used by Melee Min Target")]
    public float MeleeMinGuess = 1f;
    
    [MaintainOrder]
    [SettingName("Melee Max Guess")]
    [Tooltip("Used by Melee Max Target")]
    public float MeleeMaxGuess = 43f;
}