using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrok : Enemy
{
    private void Awake()
    {
        base.Awake();
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 100 + 2 * WaveSystem.waveSystem.Round;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
