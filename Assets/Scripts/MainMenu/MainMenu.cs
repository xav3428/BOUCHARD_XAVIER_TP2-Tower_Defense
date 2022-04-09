using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;


public class MainMenu : MonoBehaviour
{
    public Button boutonJouer;
    public Button boutonQuitter;
    public GameObject mainMenu;
    public GameObject GameUI;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        boutonJouer.onClick.AddListener(boutonJouer_OnClicked);
        boutonQuitter.onClick.AddListener(boutonQuitter_OnClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void boutonJouer_OnClicked()
    {
        mainMenu.SetActive(false);
        GameUI.SetActive(true);
        Time.timeScale = 1;
    }

    void boutonQuitter_OnClicked()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
