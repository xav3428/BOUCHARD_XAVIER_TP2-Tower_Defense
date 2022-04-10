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
    private int skeletonHP;
    private int nightshadeHP;
    private int warrokHP;
    private int bbwarrokHP;



    // Accessible properties
    public int Money { get { return money; } }
    public int Lives { get { return lives; } }
    public int Kills { get { return kills; } }
    public int SkeletonHP { get { return skeletonHP; } }
    public int NightShadeHP { get { return nightshadeHP; } }
    public int WarrokHP { get { return warrokHP; } }
    public int BBWarrokHP { get { return bbwarrokHP; } }
    
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
