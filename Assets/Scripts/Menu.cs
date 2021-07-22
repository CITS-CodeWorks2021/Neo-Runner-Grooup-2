using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Load_Save");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game is Off");
    }

}
