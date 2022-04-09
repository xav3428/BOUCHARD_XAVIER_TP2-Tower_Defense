using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatClass : MonoBehaviour
{
    // Variables
    public static StatClass statClass;
    private int money = 1000000;
    private int lives = 100;
    

    // Accessible properties
    public int Money { get { return this.money; } }
    public int Lives { get { return this.lives; } }
    
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
        money =+ value;
    }

    public void updateLifeAmount(int value)
    {
        // Here, we just substract the number of hp left on an enemy to our total hp count.
        lives =- value;
    }
}
