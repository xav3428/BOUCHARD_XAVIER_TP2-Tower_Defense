using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectionSlower : EnemyDetection
{
    int explosionRadius;
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }

    protected override void LookAtTarget(Transform targetTransform, Transform turretRotateTransform)
    {
        Vector3 targetDirection = targetTransform.position - turretRotateTransform.position;



        Vector3 newDirection = Vector3.RotateTowards(turretRotateTransform.forward, targetDirection, Time.deltaTime, 0.0f);

        turretRotateTransform.rotation = Quaternion.LookRotation(new Vector3(newDirection.x, 90, newDirection.z));
    }

    protected override void Shoot(GameObject target)
    {
        foreach (GameObject enemy in WaveSystem.waveSystem.ListEnemies)
        {
            if (Vector3.Distance(target.transform.position, enemy.transform.position) <= explosionRadius)
            {
                enemy.GetComponent<Enemy>().ApplyDamage(Random.Range(minimumDMG, maxDMG + 1));
                enemy.GetComponent<Enemy>().ApplySlow();
            }
        }
        
        BackGroundMusicSwitch.musicmanager.towers.PlayOneShot(shootingSound);
    }

}
