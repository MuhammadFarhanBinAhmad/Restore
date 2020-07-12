using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BC_BasicBuildingStats : MonoBehaviour
{
    internal ColonyManager the_CM;
    public BuildingManager the_BB;

    //Building UI
    [Header("Building UI")]
    public GameObject the_Building_UI;
    public List<TextMeshProUGUI> button_Building_Name;//list of possible build to reconstruct to
    //Building Stats
    [Header("Building Stats")]
    public List<int> cost_Of_Upgrade = new List<int>();
    public int current_Building_Level = 1;

    private void Awake()
    {
        the_CM = FindObjectOfType<ColonyManager>();
    }
    internal void Start()
    {
        the_BB = GetComponentInParent<BuildingManager>();
        for (int i = 0; i <= the_BB.building_Prefab.Count - 1; i++)
        {
            button_Building_Name[i].text = the_BB.building_Prefab[i].name.ToString();//UI name
        }
    }
    void OnMouseDown()
    {
        the_Building_UI.SetActive(true);
    }
    public void CloseBuildingUI()
    {
        the_Building_UI.SetActive(false);
    }
    //Leveling up Building
    public void AddToLevelUpList()
    {
        the_CM.building_Level_Up_List.Add(this);
    }

    public void LevelUpBuilding()
    {
        if (current_Building_Level < 4 && cost_Of_Upgrade[current_Building_Level] > the_CM.total_Material)
        {
            the_CM.total_Material -= cost_Of_Upgrade[current_Building_Level];
            current_Building_Level++;
        }
    }
}
