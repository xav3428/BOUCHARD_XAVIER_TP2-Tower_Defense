using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrok : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 100 + (2 * WaveSystem.waveSystem.Round);
    }
}
