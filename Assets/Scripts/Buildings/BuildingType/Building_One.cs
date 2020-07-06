using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_One : MonoBehaviour
{
    //use to change type of building
    public enum Current_Building
    {
        Park,
        Farm,
        Storage_Food_Water,
        School
    }
    public Current_Building the_Current_Building_Type;

    ColonyManager the_CM;

    private void Start()
    {
        the_CM = FindObjectOfType<ColonyManager>();
    }

    public void Building_Ability()
    {
        switch(the_Current_Building_Type)
        {
            case Current_Building.Park:
                {

                }
                break;
            case Current_Building.Farm:
                {

                }
                break;
            case Current_Building.Storage_Food_Water:
                {

                }
                break;
            case Current_Building.School:
                {

                }
                break;
        }
    }
}
