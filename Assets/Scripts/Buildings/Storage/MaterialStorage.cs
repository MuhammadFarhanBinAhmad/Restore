using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialStorage : BaseStorage
{
    public int current_Building_Level = 1;

    private void Start()
    {
        the_CSS.limit_Material += amount_Storeable;
    }

    void LevelingUpStorage()
    {
        if (current_Building_Level < 3)
        {
            the_CSS.total_Material += 50;//Increase Storage Space
        }
    }
}
