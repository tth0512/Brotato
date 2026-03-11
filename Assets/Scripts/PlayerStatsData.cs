
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct PlayerStatModifier
{
    public PlayerStatType statType;
    public float amount;
}

[CreateAssetMenu(fileName = "New Item", menuName = "Brotato/Character Stats")]
public class PlayerStatsData : ScriptableObject
{
    public string characterName;
    public List<PlayerStatModifier> modifiers;
}