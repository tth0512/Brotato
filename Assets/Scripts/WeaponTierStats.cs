using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct WeaponTierStats
{
    [Header("Tier level")]
    public int tierLevel;

    [Header("Offensive Stats")]
    public float baseDamage;
    public float attackSpeed;
    public List<StatScaling> statScalings;
    public float DPS
    {
        get
        {
            return baseDamage / attackSpeed;
        }
    }

    [Header("Critical & Utility Stats")]
    public float criticalDamage;
    public float criticalChance;
    public float range;
    public float knockback;
    public float lifesteal;

    [Header("Economy")]
    public float basePrice;

}
