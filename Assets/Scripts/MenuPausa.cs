using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool juegoPausado = false;
    [SerializeField] private AudioClip click;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                ResumeGame();
            }else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        juegoPausado = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void ResumeGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void RestartGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        Time.timeScale = 1f;
        if (SceneManager.GetActiveScene().name == "Lobby Salon 1")
        {   
            GameManager.ScoreLaberinto = 0;

        }else if (SceneManager.GetActiveScene().name == "Lobby Salon 2")
        {
            GameManager.ScoreLaberinto = 3;

        }else if (SceneManager.GetActiveScene().name == "Lobby Salon 3")
        {
            GameManager.ScoreLaberinto = 6;

        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

     public void QuitGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        Time.timeScale = 1f;
        GameManager.Score = 0;
        GameManager.ScoreLaberinto = 0;
        GameManager.SaveLevel = 0;
        SceneManager.LoadScene("Menu");
    }
}
