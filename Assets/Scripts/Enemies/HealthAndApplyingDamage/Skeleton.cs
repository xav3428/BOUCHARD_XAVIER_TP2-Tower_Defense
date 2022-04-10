using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 50 + (2 * WaveSystem.waveSystem.Round);
    }

    public override void Die()
    {
        base.Die();
        StatClass.statClass.addAKill();
        StatClass.statClass.updateMoneyAmount(10);
    }
}
