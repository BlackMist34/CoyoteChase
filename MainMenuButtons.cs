using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadSceneAsync("LevelSelect");
    }

    public void Credits()
    {
        SceneManager.LoadSceneAsync("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
