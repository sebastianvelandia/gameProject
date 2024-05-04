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

        if (GameManager.ScoreLaberinto <= 3)
        {
            GameManager.ScoreLaberinto = 0;
            GameManager.SaveLevel = 0;
        } else if (GameManager.ScoreLaberinto <= 6)
        {
            GameManager.ScoreLaberinto = 3;
            GameManager.SaveLevel = 2;
        } else if (GameManager.ScoreLaberinto <= 9)
        {
            GameManager.ScoreLaberinto = 6;
        }

        GameManager.EscenaAnterior = "Lobby Salon1-Museo";
        SceneManager.LoadScene("Transicion Escena");
    }
}