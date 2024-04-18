using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void Start() 
    {
        StartCoroutine(CargarEscena(2F));
    }

    private IEnumerator CargarEscena(float time)
    {
        yield return new WaitForSecondsRealtime(time);
                
        GameManager.EscenaAnterior = "Lobby Salon1-Museo";
        SceneManager.LoadScene("Transicion Escena");
    }
}