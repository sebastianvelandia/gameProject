using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private AudioClip portal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ControladorSonido.Instance.EjecutarSonido(portal);
        Scene escenaActual = SceneManager.GetActiveScene();
        string nombreEscena = escenaActual.name;

        if (nombreEscena == "Lobby Museo")
        {
            GameManager.Score = 0;
            GameManager.EscenaAnterior = "Lobby Museo";
            SceneManager.LoadScene("Transicion Escena");
            
        }else{
            GameManager.EscenaAnterior = "Lobby Historico";
            SceneManager.LoadScene("Transicion Escena");
            
        }
        int numSalon1 = GameManager.ScoreLaberinto;
        if (numSalon1 == 9)
        {
            SceneManager.LoadScene("Creditos");
        }
    }

}
