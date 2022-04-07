using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NightShadeNav : Navigation
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        var areaMask = new NavMeshHit();

        agent.SamplePathPosition(-1, 0.0f, out areaMask);
        if (areaMask.mask == 8)
        {
            animator.SetInteger("areamask", 8);
        }
        else
        {
            animator.SetInteger("areamask", 1);
        }

    }
}
