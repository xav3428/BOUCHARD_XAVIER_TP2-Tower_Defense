using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectionSlower : EnemyDetection
{
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

    
}
