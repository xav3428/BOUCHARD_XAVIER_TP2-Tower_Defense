using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    
    Rigidbody[] ragdollRbs;
    Animator animator;

    void Awake()
    {
        ragdollRbs = GetComponentsInChildren<Rigidbody>();
        animator = GetComponent<Animator>();
        ToggleRbs(true);
    }

    public void RagDollAndDelete()
    {
        ActivateRagdoll();
        Invoke("DeleteSelf", 3f);
    }

    void ActivateRagdoll()
    {
        // Disables the animator
        animator.enabled = false;

        // Enables the ragdoll physic
        ToggleRbs(false);
    }

    void ToggleRbs(bool value)
    // Enables or disables the rigidbodies of the ragdoll
    {
        foreach (Rigidbody item in ragdollRbs)
        {
            item.isKinematic = value;
        }
    }

    void DeleteSelf()
    {
        WaveSystem.waveSystem.ListEnemies.Remove(gameObject);
        Destroy(gameObject);
    }
}
