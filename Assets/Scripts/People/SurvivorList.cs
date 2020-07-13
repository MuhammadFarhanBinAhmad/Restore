using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivorList : MonoBehaviour
{

    SurvivorManager the_SM;
    public GameObject survivor_Button;
    public GameObject parent;
    public BC_BasicBuildingStats building_Currently_Selected;

    private void Start()
    {
        the_SM = FindObjectOfType<SurvivorManager>();
        this.gameObject.SetActive(false);
        CreateButtons();
    }

    void CreateButtons()
    {
        for (int i = 0; i <= the_SM.survivor_Total - 1; i++)
        {
            GameObject SB = Instantiate(survivor_Button, transform.position, transform.rotation);
            SB.transform.parent = parent.transform;
            SB.GetComponent<SurvivorHolder>().current_Survivor = the_SM.survivor_List[i].GetComponent<Survivor>();
        }
    }
    public void CloseSurvivorList()
    {
        this.gameObject.SetActive(false); building_Currently_Selected = null;
    }
    public void AssignSurvivor()
    {

    }
}
