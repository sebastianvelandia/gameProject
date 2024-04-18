using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip click;
    [SerializeField] private GameObject difficultyPanel;
    public void PlayGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        GameManager.Score = 0;
        GameManager.ScoreLaberinto = 0;
        GameManager.SaveLevel = 0;
        difficultyPanel.SetActive(true);
    }

    public void QuitGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        Application.Quit();
    }

    public void EasyLevel()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        GameManager.DifficultyLevel = "Facil";
        GameManager.EscenaAnterior = "Menu";
        SceneManager.LoadScene("Transicion Escena");
    }

    public void MediumLevel()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        GameManager.DifficultyLevel = "Medio";
        GameManager.EscenaAnterior = "Menu";
        SceneManager.LoadScene("Transicion Escena");
    }

    public void HardLevel()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        GameManager.DifficultyLevel = "Dificil";
        GameManager.EscenaAnterior = "Menu";
        SceneManager.LoadScene("Transicion Escena");
    }

}
