using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace HealthAndDamageScalingPatcher;

public class Settings
{
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
    
    [SettingName("Melee Damage Mult")]
    [Tooltip("Multiplies melee weapon damage before adding bonus")]
    public float MeleeDmgMult = 0.85f;

    [SettingName("Melee Damage Bonus")]
    [Tooltip("Adds a bonus to melee weapon damage")]
    public float MeleeDmgBonus = 6f;
}