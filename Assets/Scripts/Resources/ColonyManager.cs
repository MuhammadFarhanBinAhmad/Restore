using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyManager : MonoBehaviour
{
    //General Stats
    [Header("Basic Stats")]
    public int total_Food;
    public int total_Water;
    public int total_Material;
    public int total_Moral;
    public int total_Defense;
    [Header("Storage Limit")]
    public int limit_Food;
    public int limit_Water;
    public int limit_Material;
    public int limit_Moral = 100;
    [Header("Buildings")]
    public List<Farm> farm_List;
    public List<Reservoir> reservoir_List;
    public List<WorkShop> workshop_List;
    public List<BuildingManager> building_Reconstructing_List;
    public List<BC_BasicBuildingStats> level_Up_Building_List;

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
        if (level_Up_Building_List.Count > 0)
        {
            for (int i = 0; i < level_Up_Building_List.Count; i++)
            {
                level_Up_Building_List[i].LevelUpBuilding();
            }
        }
        ClearList();
    }
    //Clear all building in list at end of the day
    void ClearList()
    {
        building_Reconstructing_List.Clear();
        level_Up_Building_List.Clear();
    }
}
