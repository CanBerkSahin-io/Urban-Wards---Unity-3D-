﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))     // if ESC key is pressed, and the game is pasued, resume it.
        {                                          // if ESC key is pressed, and the same is not paused then pause it.
            if (GameIsPaused)
            {
                Resume();
            }  else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState= CursorLockMode.Locked; // re-locking cursor
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // 1f is normal time
        GameIsPaused = false;

    }

    void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;       // 0f is paused.
        GameIsPaused = true;

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;      // resetting time back to normal for menu screen.
        SceneManager.LoadScene("Menu");    // load menu scene
        Scoring.theScore = 0; //

    }

    public void QuitGame()
    {
        Application.Quit();     // quit application

    }

}
