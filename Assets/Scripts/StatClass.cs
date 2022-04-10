using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatClass : MonoBehaviour
{
    // Variables
    public static StatClass statClass;
    private int money = 150;
    private int kills = 0;



    // Accessible properties
    public int Money { get { return money; } }
    public int Kills { get { return kills; } }
    
    /// <summary>
    /// Functions
    /// </summary>
    private void Awake()
    {
        statClass = this;
    }

    public void updateMoneyAmount(int value)
    {
        // Here, we add the money gained from killing an enemy.
        money = money + value;
    }

    public void addAKill()
    {
        kills = kills + 1;
    }
}
