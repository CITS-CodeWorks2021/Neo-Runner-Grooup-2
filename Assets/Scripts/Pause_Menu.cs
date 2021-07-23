using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;
    public GameObject restartButtonUI;

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {

                Resume();

            }
            else
            {

                Pause();

            }



        }


        void Pause()
        {

            pausemenuUI.SetActive(true);
            restartButtonUI.SetActive(false);
            Time.timeScale = 0f;
            GameIsPaused = true;

        }




    }

    public void Resume()
    {

        pausemenuUI.SetActive(false);
        restartButtonUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void LoadMenu()
    {

        Time.timeScale = 1f;
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {

        Debug.Log("Quiting Game...");
        Application.Quit();
    }

    public void RestartGameButton()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void LoadSaveGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Load_Save");
    }

    public void options()
    {
        SceneManager.LoadScene("Settings");
        Time.timeScale = 1f;

    }

}
