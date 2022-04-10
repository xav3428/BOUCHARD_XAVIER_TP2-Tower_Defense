using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightShade : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 100 + (2 * WaveSystem.waveSystem.Round);
    }

    public override void Die()
    {
        base.Die();
        StatClass.statClass.addAKill();
        StatClass.statClass.updateMoneyAmount(20);
    }
}
