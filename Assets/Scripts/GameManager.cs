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
    private static int savelLevel;
    private static string difficultyLevel;
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

    public static int SaveLevel
    {
        get
        {
            return savelLevel;
        }

        set
        {
            savelLevel = value;
        }
    }
    public static string DifficultyLevel
    {
        get
        {
            return difficultyLevel;
        }

        set
        {
            difficultyLevel = value;
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

    public void DestroyPortal()
    {
        GameObject objetoAEliminar = GameObject.FindWithTag("portalMuseo");

        if (objetoAEliminar != null)
        {
            Destroy(objetoAEliminar);
        }
        else
        {
            Debug.Log("No se encontró elemento");
        }

    }

    public void IncScore(int inc)
    {
        score += inc;
        Debug.Log("Score historico = " + score);
    }

    public void IncScoreLaberinto(int inc)
    {
        scoreLaberinto += inc;
        Debug.Log("Score salon = " + scoreLaberinto);
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
