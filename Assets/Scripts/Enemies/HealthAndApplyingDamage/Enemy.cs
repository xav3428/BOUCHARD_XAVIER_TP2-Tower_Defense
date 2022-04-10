using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
}
