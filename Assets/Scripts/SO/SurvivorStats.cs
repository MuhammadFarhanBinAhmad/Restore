using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SurvivorData", menuName = "Occupation", order = 1)]
public class SurvivorStats : ScriptableObject
{
    public string SS_Occupation;
    public int SS_Health;
    public int SS_Strength;
    public int SS_Building_Speed;
    public int SS_Persuasion;
    public int SS_Inteligence;
    public int SS_Production_Skill;
}
