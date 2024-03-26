using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pause_menu;
    private bool paused;

    private void Start()
    {
        paused = false;
        pause_menu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                paused = true;
                pause_menu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                paused = false;
                pause_menu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}