using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrok : Enemy
{
    
    public override void SetEnemyHP()
    {
        health = 150 + (2 * WaveSystem.waveSystem.Round);
    }

    public override void Die()
    {
        base.Die();
        WaveSystem.waveSystem.spawnBabies(gameObject);
        StatClass.statClass.addAKill();
        StatClass.statClass.updateMoneyAmount(20);
    }
}
