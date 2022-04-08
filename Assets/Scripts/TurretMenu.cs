using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretMenu : MonoBehaviour
{
    [SerializeField] private Button boutonExit;
    [SerializeField] private Button boutonVendre;
    [SerializeField] private Canvas canvas;
    [SerializeField] private TurretRemovalBlueprint turretSellingConfigs;

    // Start is called before the first frame update
    void Start()
    {
        boutonExit.onClick.AddListener(boutonExit_Clicked);
        boutonVendre.onClick.AddListener(boutonVendre_Clicked);
    }

    void boutonVendre_Clicked()
    {
        StatClass.statClass.updateMoneyAmount(turretSellingConfigs.sellCost);
        Instantiate(turretSellingConfigs.gameObject, this.transform.position, this.transform.rotation);
        Destroy(gameObject);
    }

    void boutonExit_Clicked()
    {
        canvas.enabled = false;
    }
}
