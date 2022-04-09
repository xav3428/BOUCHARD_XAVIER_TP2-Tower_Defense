using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class UIStatUpdater : MonoBehaviour
{
    // Variables
    public TMP_Text moneyText;
    public TMP_Text livesText;
    public TMP_Text killsText;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = StatClass.statClass.Money.ToString();
        livesText.text = StatClass.statClass.Lives.ToString();
        killsText.text = StatClass.statClass.Kills.ToString();
    }
}
