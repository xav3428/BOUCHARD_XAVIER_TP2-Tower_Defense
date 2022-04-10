using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarrokChild : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 20 + 2 * WaveSystem.waveSystem.Round;
    }
}
