using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodWaterStorage : BaseStorage
{
    public int current_Building_Level = 1;

    private void Start()
    {
        the_CSS.limit_Food += amount_Storeable;
        the_CSS.limit_Water += amount_Storeable;
    }

    void LevelingUpStorage()
    {
        if (current_Building_Level < 3)
        {
            the_CSS.limit_Food += 50;//Increase Storage Space
            the_CSS.limit_Water += 50;//Increase Storage Space
        }
    }
}
