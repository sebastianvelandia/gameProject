using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance;
    public List<Personajes> personajes;
    private static int score;
    private static string nombreEscena;
    private static int scoreLaberinto;

    public static GameManager Instance
    {
        get
        {
            if (_Instance is null)
                Debug.Log("Game Manager is null!!");

            return _Instance;
        }
    }

    private void Awake()
    {
        if (GameManager._Instance == null)
        {
            GameManager._Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public static int ScoreLaberinto
    {
        get
        {
            return scoreLaberinto;
        }

        set
        {
            scoreLaberinto = value;
        }
    }

    public static string EscenaAnterior
    {
        set
        {
            nombreEscena = value;
        }
        get
        {
            if (nombreEscena == null)
                Debug.Log("Escena es nulo.");

            return nombreEscena;
        }
    }

    public void destroyPortal()
    {
        GameObject objetoAEliminar = GameObject.FindWithTag("portalMuseo");

        if (objetoAEliminar != null)
        {
            Debug.Log("Se encontró elemento");
            Destroy(objetoAEliminar);
        }
        else
        {
            Debug.Log("No se encontró elemento");
        }

    }

    public void incScore(int inc)
    {
        score += inc;
        Debug.Log("Estudiante recogió un objeto, score = " + score);
        if (score == 30)
        {
            Debug.Log("Estudiante recogió los 3 objetos");
        }
    }

    public void incScoreLaberinto(int inc)
    {
        scoreLaberinto += inc;
        Debug.Log("Estudiante recogió un objeto, score = " + scoreLaberinto);
        if (score == 3)
        {
            Debug.Log("Estudiante recogió los 3 objetos");
        }
    }

    public void TransicionEscena(string escena, float time)
    {
        StartCoroutine(CambiarEscena(escena, time));
    }

    private IEnumerator CambiarEscena(string escena, float time)
    {
        yield return new WaitForSecondsRealtime(time);
        SceneManager.LoadScene(escena);

    }


}
