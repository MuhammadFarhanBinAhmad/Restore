using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkShop : BC_ResourceProducing
{
    public List<Survivor> current_Workers_Assign = new List<Survivor>();

    private new void Start()
    {
        work_Left = work_Needed;
        the_CM.workshop_List.Add(this);
        base.Start();
    }
    public void MaterialProduce()
    {
        //calculate total manpower and minus off work needed to produce
        int current_Total_ManPower = 0;
        if (current_Workers_Assign.Count > 0)
        {
            for (int i = 0; i <= current_Workers_Assign.Count - 1; i++)
            {
                current_Total_ManPower += current_Workers_Assign[i].Production_Skill;//calculate total manpower
            }
            work_Left -= current_Total_ManPower;//minus off work
            print(work_Left);

        }
        //produce and reset work needed
        if (work_Left <= 0)
        {
            work_Left = work_Needed;//reset work needed
            ProduceItem(current_Building_Level);//calling derive class produce function
            the_CM.total_Material += amount_Produce;
        }
    }
}
