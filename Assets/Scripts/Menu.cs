using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject player;

    public void PauseScene()
    {
        pauseMenu.SetActive(true);
        player.SetActive(false);
        Time.timeScale = 0f;
    }
    public void UnPauseScene()
    {
        pauseMenu.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
    }
}
