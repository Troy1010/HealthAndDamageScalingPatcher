using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace HealthAndDamageScalingPatcher;

public class Settings
{
    [MaintainOrder]

    [SettingName("NPC Root Health Multiplier")]
    [Tooltip("Multiplies each npc's root health before adding bonus. Root health is used to calculate health using GameSettings")]
    public float RootHealthMult = 0.5f;

    [SettingName("NPC Health Bonus")]
    [Tooltip("Adds to each npc's root health before squeezing. Root health is used to calculate health using GameSettings")]
    public float RootHealthBonus = 20f;

    [SettingName("NPC Health Squeeze Target")]
    [Tooltip("All NPC root health values become closer to this value. Root health is used to calculate health using GameSettings")]
    public float SqueezeRootHealthTarget = 60f;

    [SettingName("NPC Health Squeeze Magnitude")]
    [Tooltip("Valid values are between 0 and infinity. Defines how powerful health squeezing is")]
    public float SqueezeRootHealthMagnitude = 1f;
    
    [SettingName("Melee Damage Mult")]
    [Tooltip("Multiplies melee weapon damage before adding bonus")]
    public float MeleeDmgMult = 0.85f;

    [SettingName("Melee Damage Bonus")]
    [Tooltip("Adds a bonus to melee weapon damage")]
    public float MeleeDmgBonus = 6f;
}