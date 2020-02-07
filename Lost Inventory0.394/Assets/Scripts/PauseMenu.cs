using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsGamePaused = false;
    public GameObject menuPauseUI;


    void Start()
    {
        menuPauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //menuPauseUI = GameObject.Find("Pause Menu");
        if (Input.GetKeyDown(KeyCode.Escape) )
        {
            if (IsGamePaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1;
        IsGamePaused = false;
    }

    public void Pause ()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0;
        IsGamePaused = true;
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
      
    }
}
