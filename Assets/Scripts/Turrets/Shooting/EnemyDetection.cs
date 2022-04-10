using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class EnemyDetection : MonoBehaviour
{
    public int minimumDMG;
    public int maxDMG;
    // Variables
    public GameObject currentTarget = null;
    private float shortestDistance = Mathf.Infinity;
    public float range = 15.0f;
    // Ugly variable name but it does the job in the inspector
    public GameObject TurretPartToRotateInACircle;

    protected virtual void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (currentTarget == null)
        {
            return;
        }
        LookAtTarget(currentTarget.transform, TurretPartToRotateInACircle.transform);

    }

    protected void UpdateTarget()
    {
        // If the target equals null means that if it is dead. (or simply, doesn't exist anymore)
        if (currentTarget == null || currentTarget.tag == "DeadEnemy")
            foreach (GameObject enemy in WaveSystem.waveSystem.ListEnemies)
            {
                if (Vector3.Distance(transform.position, enemy.transform.position) <= range)
                {
                    // Here, we get the enemy path distance left to
                    // travel to see if its smaller than our previous one
                    // (This, at the end of the foreach loop, will give
                    // us the enemy that's the furthest on the path in the turret's range)
                    float enemyDistance = GetRemainingDistance(enemy.GetComponent<NavMeshAgent>());

                    if (enemyDistance < shortestDistance && enemy.tag == "Enemy")
                    {
                        currentTarget = enemy;
                    }
                    else
                    {
                        currentTarget = null;
                    }
                    
                }
            }
        if (currentTarget != null && currentTarget.tag == "Enemy")
        {
            if (Vector3.Distance(transform.position, currentTarget.transform.position) <= range)
            {
                Shoot(currentTarget);

            }
            else
            {
                currentTarget = null;
            }
        }

        
        


        
    }

    
    float GetRemainingDistance(NavMeshAgent navMeshAgent)
    {
        float distance = 0.0f;
        for (int i = 0; i < navMeshAgent.path.corners.Length - 1; ++i)
        {
            distance += Vector3.Distance(navMeshAgent.path.corners[i], navMeshAgent.path.corners[i + 1]);
        }

        return distance;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    protected virtual void LookAtTarget(Transform targetTransform, Transform turretRotateTransform)
    {
        Vector3 targetDirection = targetTransform.position - turretRotateTransform.position;

        
        
        Vector3 newDirection = Vector3.RotateTowards(turretRotateTransform.forward, targetDirection, Time.deltaTime, 0.0f);
        
        turretRotateTransform.rotation = Quaternion.LookRotation(new Vector3(newDirection.x, 90, newDirection.z));
    }

    protected void RotateTopPart(Transform Top, Transform target)
    {
        Top.LookAt(target);
        
    }

    protected virtual void Shoot(GameObject target)
    {

    }


}
