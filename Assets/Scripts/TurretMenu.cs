using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretMenu : MonoBehaviour
{
    [SerializeField] private Button boutonExit;
    [SerializeField] private Button boutonVendre;
    [SerializeField] Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        boutonExit.onClick.AddListener(boutonExit_Clicked);
        boutonVendre.onClick.AddListener(boutonVendre_Clicked);
    }

    void boutonVendre_Clicked()
    {

    }

    void boutonExit_Clicked()
    {
        canvas.enabled = false;
    }
}
