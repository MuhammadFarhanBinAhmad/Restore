using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UpgradeAbility
{
    public string ability_Name;
    public int level_Needed;
    public int total_Lab_Needed;
    public int scientist_Needed;
    public int days_Needed;
}
[System.Serializable]
public class TotalLab
{
    public int total_Lab;//gather total lab of specific level
}
public class Lab : BC_BasicBuildingStats
{
    [Header("Ability Criteria")]
    public List<UpgradeAbility> unlockable_Abilities = new List<UpgradeAbility>();
    [Header("Total Lab")]
    /// <summary>
    /// 0 = leve1 1
    /// 1 = leve1 2
    /// 2 = leve1 3
    /// </summary>
    public TotalLab[] total_Lab_Amount = new TotalLab[3];
    public List<bool> ability_Unlocked;

    public void UnlockAbility(int ability_To_Unlock)
    {
        ability_Unlocked[ability_To_Unlock] = true;
    }
}
