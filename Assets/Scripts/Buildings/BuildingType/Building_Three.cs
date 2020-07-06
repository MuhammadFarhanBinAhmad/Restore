using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Three : MonoBehaviour
{
    public enum Current_Building
    {
        Hospital,
        WorkShop,
        Storage_Material,
        Factory
    }
    public Current_Building the_Current_Building_Type;

    ColonyManager the_CM;

    private void Start()
    {
        the_CM = FindObjectOfType<ColonyManager>();
        //the_CM.the_Building_Three_List.Add(this);
    }

    public void Building_Ability()
    {
        switch (the_Current_Building_Type)
        {
            case Current_Building.Hospital:
                {

                }
                break;
            case Current_Building.WorkShop:
                {
                    the_CM.total_Material += 5;

                }
                break;
            case Current_Building.Storage_Material:
                {
                }
                break;
            case Current_Building.Factory:
                {

                }
                break;
        }
    }
}
