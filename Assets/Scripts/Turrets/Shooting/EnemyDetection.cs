using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class EnemyDetection : MonoBehaviour
{
    // Variables
    public GameObject currentTarget = null;
    private float shortestDistance = Mathf.Infinity;
    private List<float> remainingDistances = new List<float>();
    private List<GameObject> enemiesInRange = new List<GameObject>();
    public float range = 15.0f;
    // Ugly variable name but it does the job in the inspector
    public GameObject TurretPartToLookUpAndDown;
    public GameObject TurretPartToRotateInACircle;

    private void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTarget == null)
        {
            return;
        }
        LookAtTarget(currentTarget.transform, TurretPartToRotateInACircle.transform, TurretPartToLookUpAndDown.transform);

    }

    void UpdateTarget()
    {
        // If the target equals null means that if it is dead. (or simply, doesn't exist anymore)
        if (currentTarget == null)
            foreach (GameObject enemy in WaveSystem.waveSystem.ListEnemies)
            {
                if (Vector3.Distance(transform.position, enemy.transform.position) <= range)
                {
                    // Here, we get the enemy path distance left to
                    // travel to see if its smaller than our previous one
                    // (This, at the end of the foreach loop, will give
                    // us the enemy that's the furthest on the path in the turret's range)
                    float enemyDistance = GetRemainingDistance(enemy.GetComponent<NavMeshAgent>());

                    if (enemyDistance < shortestDistance)
                    {
                        currentTarget = enemy;
                    }
                    
                }
            }
        if (currentTarget != null)
        {
            if (Vector3.Distance(transform.position, currentTarget.transform.position) <= range)
            {
                // shoot at target
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

    void LookAtTarget(Transform targetTransform, Transform turretRotateTransform, Transform turretTopTransform)
    {
        Vector3 targetDirection = targetTransform.position - turretRotateTransform.position;

        float instaStep = Time.deltaTime;
        
        Vector3 newDirection = Vector3.RotateTowards(turretRotateTransform.forward, targetDirection, instaStep, 0.0f);
        
        turretRotateTransform.rotation = Quaternion.LookRotation(new Vector3(newDirection.x, 90, newDirection.z));
        turretTopTransform.LookAt(targetTransform);

    }



}
