using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct StatModifier
{
    public PrimaryStats primaryStats;
    public SecondaryStats secondaryStats;
    public DLCStats dLCStats;
    public float amount;
}

[CreateAssetMenu(fileName = "New Item", menuName = "Brotato/Character Stats")]
public class StatsData : ScriptableObject
{
    public string itemName;
    public List<StatModifier> modifiers;
}