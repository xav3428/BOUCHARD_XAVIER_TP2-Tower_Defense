using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightShade : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 50 + (2 * WaveSystem.waveSystem.Round);
    }
}
