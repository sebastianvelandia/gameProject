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
            Debug.Log("Estudiante entra al portal de historico");
            GameManager.Score = 0;
            GameManager.EscenaAnterior = "Lobby Museo";
            SceneManager.LoadScene("Transicion Escena");
            
        }else{
            Debug.Log("Estudiante entra al portal de museo");
            GameManager.EscenaAnterior = "Lobby Historico";
            SceneManager.LoadScene("Transicion Escena");
            
        }
    }

}
