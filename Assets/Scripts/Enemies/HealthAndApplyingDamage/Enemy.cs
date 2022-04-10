using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    protected int health;
    public Slider healthbar;

    public int Health { get { return health; } }

    // Start is called before the first frame update
    protected void Start()
    {
        InitHealthbar();
    }

    private void Update()
    {
        UpdateHealthBar();
        if (health <= 0 && gameObject.tag == "Enemy")
        {
            Die();
        }
    }

    public void ApplyDamage(int damage)
    {
        health -= damage;
    }
    public virtual void SetEnemyHP() { }

    public void InitHealthbar()
    {
        healthbar.maxValue = Health;
        healthbar.value = Health;
    }

    public void UpdateHealthBar()
    {
        healthbar.value = Health;
    }

    public virtual void Die()
    {
        if (health <= 0)
        {
            gameObject.tag = "DeadEnemy";
            GetComponent<Ragdoll>().RagDollAndDelete();
            GetComponent<NavMeshAgent>().isStopped = true;
        }
        
    }

    public void ApplySlow()
    {
        GetComponent<NavMeshAgent>().speed = GetComponent<NavMeshAgent>().speed / 2;
        Invoke("RemoveSlow", 2f);
    }

    public void RemoveSlow()
    {
        GetComponent<NavMeshAgent>().speed = GetComponent<NavMeshAgent>().speed * 2;
    }
}
