using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace HealthAndDamageScalingPatcher;

public class Settings
{
    [MaintainOrder]

    [SettingName("NPC Health Multiplier")]
    [Tooltip("Multiplies each npc's health before adding bonus")]
    public float HealthMult = 0.5f;

    [SettingName("NPC Health Bonus")]
    [Tooltip("Adds to each npc's health before squeezing")]
    public float HealthBonus = 20f;

    [SettingName("NPC Health Squeeze Target")]
    [Tooltip("All NPC health values become closer to this value")]
    public float SqueezeHealthTarget = 60f;

    [SettingName("NPC Health Squeeze Magnitude")]
    [Tooltip("Valid values are between 0 and infinity. Defines how powerful health squeezing is")]
    public float SqueezeHealthMagnitude = 1f;
}