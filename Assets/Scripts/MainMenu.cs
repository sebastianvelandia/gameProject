using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Lobby Universidad");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Home()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
