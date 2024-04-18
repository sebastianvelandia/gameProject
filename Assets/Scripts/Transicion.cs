using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Transicion : MonoBehaviour
{
    public Animator animator;
    private TextMeshProUGUI titulo;

    private void Start() {
        // animator.Play("Panel", 0, 0);
        string nombreEscenaAnterior = GameManager.EscenaAnterior;
        if (nombreEscenaAnterior == "Lobby Museo-Salon1")
        {
            titulo = FindObjectOfType<TextMeshProUGUI>();
            if (titulo.CompareTag("Titulo"))
            {
                titulo.text = "Salon de Sistemas Digitales";
            }
        } else if (nombreEscenaAnterior == "Lobby Museo-Salon2")
        {
            titulo = FindObjectOfType<TextMeshProUGUI>();
            if (titulo.CompareTag("Titulo"))
            {
                titulo.text = "Salon de Automatización";
            }
        } else if (nombreEscenaAnterior == "Lobby Museo-Salon3")
        {
            titulo = FindObjectOfType<TextMeshProUGUI>();
            if (titulo.CompareTag("Titulo"))
            {
                titulo.text = "Salon de Telecomunicaciones";
            }
        }
        
    }

    public void LoadScene(){
        string nombreEscenaAnterior = GameManager.EscenaAnterior;
        switch (nombreEscenaAnterior)
        {
            case "Menu":
                GameManager.Instance.TransicionEscena("Lobby Universidad",1.5F);
                break;
            case "Lobby Universidad":
                GameManager.Instance.TransicionEscena("Lobby Museo",1.5F);
                break;
            case "Lobby Museo":
                GameManager.Instance.TransicionEscena("Lobby Historico",1.5F);
                break;
            case "Lobby Historico":
                GameManager.Instance.TransicionEscena("Lobby Museo",1.5F);
                break;
            case "Lobby Museo-Uni":
                GameManager.Instance.TransicionEscena("Lobby Universidad",1.5F);
                break;
            case "Lobby Museo-Salon1":
                if (GameManager.ScoreLaberinto <= 3)
                {
                    GameManager.ScoreLaberinto = 0;
                }
                GameManager.Instance.TransicionEscena("Lobby Salon 1",1.5F);
                break;
            case "Lobby Museo-Salon2":
                if (GameManager.ScoreLaberinto <= 6)
                {
                    GameManager.ScoreLaberinto = 3;
                }
                GameManager.Instance.TransicionEscena("Lobby Salon 2",1.5F);
                break;
            case "Lobby Museo-Salon3":
                if (GameManager.ScoreLaberinto <= 9)
                {
                    GameManager.ScoreLaberinto = 6;
                }
                GameManager.Instance.TransicionEscena("Lobby Salon 3",1.5F);
                break;
            case "Lobby Salon1-Museo":
                GameManager.Instance.TransicionEscena("Lobby Museo",1.5F);
                break;
        }
    }

}
