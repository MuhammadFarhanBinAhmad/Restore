using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStorage : MonoBehaviour
{
    internal ColonyManager the_CSS;
    public int amount_Storeable = 50;

    // Start is called before the first frame update
    void Awake()
    {
        the_CSS = FindObjectOfType<ColonyManager>();
    }
}
