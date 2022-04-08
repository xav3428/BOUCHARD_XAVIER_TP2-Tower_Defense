using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyMenu : MonoBehaviour
{
    [SerializeField] private Button boutonFusil;
    [SerializeField] private Button boutonBombe;
    [SerializeField] private Button boutonGlace;
    [SerializeField] private Button boutonExit;
    [SerializeField] private GameObject prefabFusil;
    [SerializeField] private GameObject prefabGlace;
    [SerializeField] private GameObject prefabBombe;
    [SerializeField] private Canvas canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        boutonFusil.onClick.AddListener(boutonFusil_Clicked);
        boutonBombe.onClick.AddListener(boutonBombe_Clicked); 
        boutonGlace.onClick.AddListener(boutonGlace_Clicked);
        boutonExit.onClick.AddListener(boutonExit_Clicked);
    }

    void boutonFusil_Clicked()
    {
        if (StatClass.statClass.Money >= 150)
        {
            StatClass.statClass.updateMoneyAmount(-150);
            spawnTurret(prefabFusil);
            Destroy(gameObject);
        }
        
    }

    void boutonBombe_Clicked()
    {
        if (StatClass.statClass.Money >= 450)
        {
            StatClass.statClass.updateMoneyAmount(-450);
            spawnTurret(prefabBombe);
            Destroy(gameObject);
        }
    }

    void boutonGlace_Clicked()
    {
        if (StatClass.statClass.Money >= 300)
        {
            StatClass.statClass.updateMoneyAmount(-300);
            spawnTurret(prefabGlace);
            Destroy(gameObject);
        }
    }

    void boutonExit_Clicked()
    {
        canvas.enabled = false;
    }
    
    void spawnTurret(GameObject prefab)
    {
        Instantiate(prefab, this.transform.position, this.transform.rotation);
    }
}
