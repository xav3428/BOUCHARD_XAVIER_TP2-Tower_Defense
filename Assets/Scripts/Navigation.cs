using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    protected Vector3 destinationPoint;
    protected NavMeshAgent agent;
    protected Animator animator;

    // Start is called before the first frame update
    protected void Start()
    {
        destinationPoint = GameObject.Find("EndPoint").transform.position;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        agent.SetDestination(destinationPoint);
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
