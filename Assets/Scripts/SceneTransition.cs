﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Game_Screen");
    }
}