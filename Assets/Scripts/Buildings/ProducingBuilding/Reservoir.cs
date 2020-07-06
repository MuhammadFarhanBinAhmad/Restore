using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reservoir : BC_ResourceProducing
{
    //public int current_Building_Level = 1;

    private new void Start()
    {
        the_CM.reservoir_List.Add(this);//YOU JUST MADE THE LIST
        base.Start();
    }

    public void WaterProduce()
    {
        ProduceItem(current_Building_Level);//calling derive class produce function
        the_CM.total_Water += amount_Produce;
    }
}
