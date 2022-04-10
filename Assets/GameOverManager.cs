using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
public class GameOverManager : MonoBehaviour
{
    public Collider endZone;
    public TMP_Text gameover;
    
    // Update is called once per frame
    void Update()
    {
        foreach (GameObject item in WaveSystem.waveSystem.ListEnemies)
        {
            if (endZone.bounds.Contains(item.transform.position))
            {
                Time.timeScale = 0;
                gameover.text = "Game Over";
                Invoke("Close", 2f);
            }
        }
    }
    void Close()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
