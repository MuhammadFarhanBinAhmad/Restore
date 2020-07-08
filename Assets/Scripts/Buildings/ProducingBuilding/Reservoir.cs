using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reservoir : BC_ResourceProducing
{
    //public int current_Building_Level = 1;
    public List<Survivor> current_Workers;

    private new void Start()
    {
        the_CM.reservoir_List.Add(this);//YOU JUST MADE THE LIST
        base.Start();
    }
    //check if enough work is done
    public void CheckManPower(int total_Manpower)
    {
        work_Done -= total_Manpower;//minus off work needed
        if (work_Done <= 0)
        {
            WaterProduce();
            work_Done = work_Needed;//reset work needed
        }
    }
    public void WaterProduce()
    {
        ProduceItem(current_Building_Level);//calling derive class produce function
        the_CM.total_Water += amount_Produce;
    }
}
