using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public void ResumeButton()
    {
        Time.timeScale = 1f;

        gameObject.SetActive(false);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
