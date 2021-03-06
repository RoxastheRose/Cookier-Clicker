using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject player;
    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void GoToTitleScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }

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
