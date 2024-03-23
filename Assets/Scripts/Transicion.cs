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
        animator.Play("Panel", 0, 0);
        string nombreEscenaAnterior = GameManager.EscenaAnterior;
        if (nombreEscenaAnterior == "Lobby Museo-Salon1")
        {
            titulo = FindObjectOfType<TextMeshProUGUI>();
            if (titulo.CompareTag("Titulo"))
            {
                titulo.text = "Salon de Sistemas Digitales";
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
                GameManager.Instance.TransicionEscena("Lobby Salon 1",1.5F);
                break;
            case "Lobby Salon1-Museo":
                // GameManager.Instance.TransicionEscena("GameOver",2F);
                GameManager.Instance.TransicionEscena("Lobby Museo",1.5F);
                break;
        }
    }

}
