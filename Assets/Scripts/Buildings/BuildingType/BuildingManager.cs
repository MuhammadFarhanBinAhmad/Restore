using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public int New_Building_Num;
    public int test;
    ColonyManager the_CM;

    [Header("Building")]
    public List<GameObject> building_Prefab = new List<GameObject>();
    public GameObject current_Building;
    public GameObject new_Building;
    public GameObject parent;

    void Start()
    {
        the_CM = FindObjectOfType<ColonyManager>();
    }
    public void NewBuilding(int NewBuilding)
    {
        GameObject NB = Instantiate(building_Prefab[NewBuilding], transform.position, transform.parent.rotation);
        Destroy(transform.parent.gameObject);
        //NB.transform.parent = this.GetComponentInParent<Transform>().transform;
    }
    //create new building
    public void Reconstruct(int NewBuilding)//input number
    {
        New_Building_Num = NewBuilding;
        the_CM.building_Reconstructing_List.Add(this);
    }
    public void CancleReconstruction()
    {
        the_CM.building_Reconstructing_List.Remove(this);
    }
}
