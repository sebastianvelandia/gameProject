using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip click;
    public void PlayGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        GameManager.EscenaAnterior = "Menu";
        SceneManager.LoadScene("Transicion Escena");
    }

    public void QuitGame()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        Application.Quit();
    }

}
