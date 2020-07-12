using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : BC_BasicBuildingStats
{
    public List<Survivor> survivor_To_Retrain;
    public int occupation_New;
    SurvivorManager the_SM;

    private new void Start()
    {
        base.Start();
        the_SM = FindObjectOfType<SurvivorManager>();
    }

    public void SurvivorToRetrain(int NewOccupation)
    {
        the_CM.building_Retraining_List.Add(this);
        occupation_New = NewOccupation;//set what job to change to
    }

    internal void RetrainingSurvivor()
    {
        for (int i = 0; i <= survivor_To_Retrain.Count - 1; i++)
        {
            survivor_To_Retrain[i].survivor_Current_Stats = the_SM.occupation_List[occupation_New];//set survivor to new occupation selected
        }
    }

}
