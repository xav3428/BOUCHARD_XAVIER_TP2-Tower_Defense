using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Enemy.enemyPointer.Health);
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = Enemy.enemyPointer.Health;
    }
}
