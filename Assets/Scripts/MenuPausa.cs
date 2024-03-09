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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

     public void QuitGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
