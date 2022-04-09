using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatClass : MonoBehaviour
{
    // Variables
    public static StatClass statClass;
    private int money = 150;
    private int lives = 100;
    private int kills = 0;
    

    // Accessible properties
    public int Money { get { return money; } }
    public int Lives { get { return lives; } }
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

    public void updateLifeAmount(int value)
    {
        // Here, we just substract the number of hp left on an enemy to our total hp count.
        lives = lives - value;
    }

    public void addAKill()
    {
        kills = kills + 1;
    }
}
