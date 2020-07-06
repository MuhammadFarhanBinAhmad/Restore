using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkShop : BC_ResourceProducing
{
    //public int current_Building_Level = 1;

    private new void Start()
    {
        the_CM.workshop_List.Add(this);
        base.Start();
    }
    public void MaterialProduce()
    {
        ProduceItem(current_Building_Level);//calling derive class produce function
        the_CM.total_Material += amount_Produce;
    }
}
