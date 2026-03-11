using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Brotato/Weapon")]
public class WeaponData : ScriptableObject
{
    public string WeaponName;
    public List<WeaponClass> weaponClasses;
    public bool hasSpecialEffect;
    public string SpecialEffectClass;
    public GameObject weaponPrefab;
    public Sprite weaponSprite;

    public WeaponTierStats[] tierStats;
}
