using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Two : MonoBehaviour
{
    public enum Current_Building
    {
        Bar,
        Storage_Food_Water,
        Reservoir,
        Lab
    }
    public Current_Building the_Current_Building_Type;
    ColonyManager the_CM;

    public GameObject[] building_Prefab = new GameObject[4];
    public GameObject current_Building;

    private void Start()
    {
        the_CM = FindObjectOfType<ColonyManager>();
    }

    public void Building_Ability()
    {
        switch (the_Current_Building_Type)
        {
            case Current_Building.Bar:
                {
                    current_Building = building_Prefab[1];
                }
                break;
            case Current_Building.Storage_Food_Water:
                {
                    current_Building = building_Prefab[1];
                }
                break;
            case Current_Building.Reservoir:
                {
                    current_Building = building_Prefab[1];
                }
                break;
            case Current_Building.Lab:
                {
                    current_Building = building_Prefab[1];
                }
                break;
        }
    }
}
