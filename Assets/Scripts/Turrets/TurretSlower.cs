using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSlower : TurretManager
{
    [SerializeField] private int cost = 225;
    [SerializeField] private GameObject ganvas;
    // Start is called before the first frame update
    void Start()
    {
        ganvas.SetActive(true);
        base.Start();
    }
}
