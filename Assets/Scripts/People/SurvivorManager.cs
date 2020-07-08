using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorManager : MonoBehaviour
{
    public GameObject survivor_Blank;
    /// <summary>
    /// 0 = CIVILIAN
    /// 1 = CONSTRUCTOR
    /// 2 = LEADER
    /// 3 = SCIENTIST
    /// 4 = SOLDIER
    /// 5 = WORKER
    /// </summary>

    [Header("StartingSurvivor")]
    public List<int> starting_Amount;
    [Header("SurvivorStats")]
    public List<SurvivorStats> occupation_List;
    public List<string> R_name_First;
    public List<string> R_name_Second;

    private void Start()
    {
        ////start with 15
        for (int j = 0; j <= 5; j++)
        {
            for (int i = 1; i <= starting_Amount[j]; i++)
            {
                GameObject NS = Instantiate(survivor_Blank, transform.position, transform.rotation);
                NS.GetComponent<Survivor>().survivor_Current_Stats = occupation_List[j];
                NS.transform.parent = this.gameObject.transform;
            }
        }
    }
}
