using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivor : MonoBehaviour
{

    SurvivorManager the_SM;
    public SurvivorStats survivor_Current_Stats;
    [Header("PlayerStats")]
    public string name_First;
    public string name_Second;
    public string survivor_Current_Occupation;
    public int 
        Health_Limit, 
        Health_Current, 
        Strength, 
        Building_Speed, 
        Persuasion, 
        Inteligence,
        Production_Skill;
    public void Start()
    {
        the_SM = FindObjectOfType<SurvivorManager>();
        //give random name
        name_First = the_SM.R_name_First[Random.Range(0, the_SM.R_name_First.Capacity)];
        name_Second = the_SM.R_name_Second[Random.Range(0, the_SM.R_name_Second.Capacity)];
        gameObject.name = name_First + " " + name_Second;
        Health_Current = Health_Limit;
        NewOccupation();
    }
    //Set occupation stats
    public void NewOccupation()
    {
        survivor_Current_Occupation = survivor_Current_Stats.SS_Occupation;
        Health_Limit = survivor_Current_Stats.SS_Health;
        Strength = survivor_Current_Stats.SS_Strength;
        Building_Speed = survivor_Current_Stats.SS_Building_Speed;
        Persuasion = survivor_Current_Stats.SS_Persuasion;
        Inteligence = survivor_Current_Stats.SS_Inteligence;
        Production_Skill = survivor_Current_Stats.SS_Production_Skill;
    }

}
