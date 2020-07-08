using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BC_ResourceProducing : BC_BasicBuildingStats
{
    public int amount_Produce;

    public int work_Needed;
    internal int work_Done;

    private new void Start()
    {
        work_Done = work_Needed;
    }
    //change level of building
    public void ProduceItem(int c_level)
    {
        //how much is going to be produce
        switch (c_level)
        {
            case 1:
                {
                    amount_Produce = 5;
                    break;
                }
            case 2:
                {
                    amount_Produce = 10;
                    break;
                }
            case 3:
                {
                    amount_Produce = 15;
                    break;
                }
        }
    }
}
