using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    public bool die = false;
    Rigidbody[] ragdollRbs;
    Animator animator;

    void Awake()
    {
        ragdollRbs = GetComponentsInChildren<Rigidbody>();
        animator = GetComponent<Animator>();

        ToggleRbs(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (die == true)
        {
            die = false;
            Die();
            Invoke("DeleteSelf", 3f);
        }
    }

    void Die()
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
        Destroy(gameObject);
    }
}
