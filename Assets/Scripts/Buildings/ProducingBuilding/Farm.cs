using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : BC_ResourceProducing
{
    //public int current_Building_Level = 1;

    private new void Start()
    {
        the_CM.farm_List.Add(this);
        base.Start();
    }

    public void FoodProduce()
    {
        ProduceItem(current_Building_Level);//calling derive class produce function
        the_CM.total_Food += amount_Produce;
    }

    /*void LevelUpBuilding()
    {
        if (current_Building_Level <4 && cost_Of_Upgrade[current_Building_Level] > the_CM.total_Material)
        {
            the_CM.total_Material -= cost_Of_Upgrade[current_Building_Level];
            current_Building_Level++;
        }
    }*/

}
