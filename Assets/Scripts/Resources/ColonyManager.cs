using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyManager : MonoBehaviour
{
    //General Stats
    [Header("Basic Stats")]
    public int 
        total_Food, 
        total_Water, 
        total_Material, 
        total_Moral,
        total_Defense;
    [Header("Storage Limit")]
    public int 
        limit_Food, 
        limit_Water, 
        limit_Material, 
        limit_Moral = 100;
    [Header("Buildings")]
    public List<Farm> farm_List;
    public List<Reservoir> reservoir_List;
    public List<WorkShop> workshop_List;
    public List<BuildingManager> building_Reconstructing_List;
    public List<BC_BasicBuildingStats> building_Level_Up_List;
    public List<School> building_Retraining_List;
    public int total_Lab;
    [Header("Lab Research")]
    public int lab_Researching;
    public bool lab_Currently_Researching;
    public int lab_Research_Days_Left;
    Lab the_L;
    [Header("Total Population")]
    public int 
        total_Population, 
        total_scientist, 
        total_Soldier, 
        total_Leader, 
        total_Builder;

    private void Start()
    {
        the_L = FindObjectOfType<Lab>();
    }
    //Note:Please clean this shit up pls
    public void EndDay()
    {
        //All produce for the day
        for (int i = 0; i < farm_List.Count; i++)
        {
            farm_List[i].FoodProduce();
        }
        for (int i = 0; i < reservoir_List.Count; i++)
        {
            reservoir_List[i].WaterProduce();
        }
        for (int i = 0; i < workshop_List.Count; i++)
        {
            workshop_List[i].MaterialProduce();
        }
        //check storage
        if (total_Material >= limit_Material)
        {
            total_Material = limit_Material;
        }
        if (total_Food >= limit_Food)
        {
            total_Food = limit_Food;
        }
        if (total_Water >= limit_Water)
        {
            total_Water = limit_Water;
        }
        //Reconstruct building
        if (building_Reconstructing_List.Count > 0)
        {
            for (int i = 0; i < building_Reconstructing_List.Count ; i++)
            {
                building_Reconstructing_List[i].NewBuilding(building_Reconstructing_List[i].New_Building_Num);
            }
        }
        //Level Up Building
        if (building_Level_Up_List.Count > 0)
        {
            for (int i = 0; i < building_Level_Up_List.Count; i++)
            {
                building_Level_Up_List[i].LevelUpBuilding();
            }
        }
        //lab currently researching
        {
            if (lab_Research_Days_Left >0)
            {
                lab_Research_Days_Left--;
            }
            else
            {
                //unlocking research
                the_L.unlockable_Abilities[lab_Researching].ability_Unlocked = true;
                lab_Currently_Researching = false;
            }
        }
        /*if (building_Retraining_List.Count > 0)
        {
            for (int i = 0; i <= building_Retraining_List.Count-1; i++)
            {
                building_Retraining_List[i].RetrainingSurvivor()
            }
        }*/
        ClearList();
    }
    internal void SettingUpResearch(int ability_To_Unlock)
    {
        if (!lab_Currently_Researching)
        {
            lab_Researching = ability_To_Unlock;//set up what to research
            lab_Currently_Researching = true;
            lab_Research_Days_Left = the_L.unlockable_Abilities[ability_To_Unlock].days_Needed;
        }
    }
    //Clear all building in list at end of the day
    void ClearList()
    {
        building_Reconstructing_List.Clear();
        building_Level_Up_List.Clear();
    }
}
