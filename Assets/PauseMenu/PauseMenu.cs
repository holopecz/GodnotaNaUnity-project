using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pause_menu;
    [SerializeField] private GameObject options_menu;
    public bool paused;
    public bool inOptions;


    private void Start()
    {
        paused = false;
        pause_menu.SetActive(false);
        inOptions = false;
        options_menu.SetActive(false);
    }

    public void setInOptions()
    {
        inOptions = true;

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
               
                if(inOptions)
                {
                    options_menu.SetActive(false);
                    pause_menu.SetActive(true);
                    inOptions = false;
                }
                else
                {
                    paused = false;
                    pause_menu.SetActive(false);
                    options_menu.SetActive(false);
                    Time.timeScale = 1;
                }
            }
        }
  
    }

    public void Quit()
    {
        Application.Quit();
    }
}