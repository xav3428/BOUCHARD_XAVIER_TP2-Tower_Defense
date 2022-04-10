using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarrokChild : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 10 + 2 * WaveSystem.waveSystem.Round;
    }

    public override void Die()
    {
        base.Die();
        StatClass.statClass.addAKill();
        StatClass.statClass.updateMoneyAmount(5);
    }
}
