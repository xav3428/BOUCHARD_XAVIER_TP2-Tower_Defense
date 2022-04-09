using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Enemy enemyPointer;
    protected static int health;

    public int Health { get { return health; } }

    protected void Awake()
    {
        enemyPointer = this;
    }

    // Start is called before the first frame update
    protected virtual void Start(){}

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void ApplyDamage(int damage)
    {
        health -= damage;
    }
}
