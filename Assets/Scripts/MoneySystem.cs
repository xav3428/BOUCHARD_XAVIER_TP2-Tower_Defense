using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public static MoneySystem moneySystem;
    private int money = 300;
    public int Money { get { return this.money; } }

    

    private void Awake()
    {
        moneySystem = this;
    }
    
    public void updateMoneyAmount(int value)
    {
        money = money + value;
    }
}
