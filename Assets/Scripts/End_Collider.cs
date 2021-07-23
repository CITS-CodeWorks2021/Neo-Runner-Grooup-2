using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Collider : MonoBehaviour
{
    public GameObject end_menuUI;
    public GameObject restartButtonUI;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            end_menuUI.SetActive(true);
            restartButtonUI.SetActive(false);
            Time.timeScale = 0f;
        }

    }
}
