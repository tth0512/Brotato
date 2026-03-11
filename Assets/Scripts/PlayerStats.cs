using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    
    private Dictionary<PlayerStatType, float> stats = new Dictionary<PlayerStatType, float>();


    private void Awake()
    {
   
        foreach (PlayerStatType type in System.Enum.GetValues(typeof(PlayerStatType)))
        {
            stats[type] = 0f;
        }
    }
    public float GetStat(PlayerStatType type)
    {
        return stats[type];
    }

    public void SetStat(PlayerStatType type, float amount)
    {
        stats[type] = amount;

        // Gọi Event update UI ở đây
    }

    public void ApplyItem(PlayerStatsData item)
    {
        foreach (var modifier in item.modifiers)
        {
            SetStat(modifier.statType, modifier.amount);
        }
    }
}