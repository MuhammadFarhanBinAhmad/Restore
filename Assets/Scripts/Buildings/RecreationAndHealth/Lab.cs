using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UpgradeAbility
{
    public string ability_Name;
    public int total_Lab_Needed;
    public int scientist_Needed;
    public int material_Needed;
    public int days_Needed;
    public bool ability_Unlocked;
}

public class Lab : BC_BasicBuildingStats
{
    [Header("Ability Criteria")]
    public List<UpgradeAbility> unlockable_Abilities = new List<UpgradeAbility>();
    //[Header("Total Lab")]
    /*/// <summary>
    /// 0 = level 1
    /// 1 = level 2
    /// 2 = level 3
    /// </summary>
    public int[] total_Lab = new int[3];//gather total lab of specific level*/
    private new void Start()
    {
        the_CM.total_Lab++;
        base.Start();
    }
    public void UnlockAbility(int ability_To_Unlock)
    {
        if (!the_CM.lab_Currently_Researching)
        {
            if (the_CM.total_Material > unlockable_Abilities[ability_To_Unlock].material_Needed && //check if theres enough material
                the_CM.total_Lab >= unlockable_Abilities[ability_To_Unlock].total_Lab_Needed && //check if theres enough of lab
                the_CM.total_scientist >= unlockable_Abilities[ability_To_Unlock].scientist_Needed) // check if theres enough scientist
            {
                the_CM.SettingUpResearch(ability_To_Unlock);
            }
        }
    }
}
