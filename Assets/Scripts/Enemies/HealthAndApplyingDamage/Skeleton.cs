using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 75 + (2 * WaveSystem.waveSystem.Round);
    }
}
