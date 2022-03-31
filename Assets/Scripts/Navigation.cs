using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    [SerializeField] static Vector3 destinationPoint;
    NavMeshAgent agent;

    // Start is called before the first frame update
    protected void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(destinationPoint);
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
