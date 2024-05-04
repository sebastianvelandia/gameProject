using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLaberinto : MonoBehaviour
{
    [SerializeField] private AudioClip item;
    [SerializeField] private int objetoObtenido;
    [SerializeField] private Puntaje puntaje;
    [SerializeField] private GameObject portalNextLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        puntaje.SumarObjetos(objetoObtenido);
        ControladorSonido.Instance.EjecutarSonido(item);
        GameManager.Instance.IncScoreLaberinto(objetoObtenido);

        if (GameManager.ScoreLaberinto == 3)
        {
            portalNextLevel.SetActive(true);
            puntaje.MostrarMensaje();
            GameManager.SaveLevel = 2;
        } else if (GameManager.ScoreLaberinto == 6)
        {
            portalNextLevel.SetActive(true);
            puntaje.MostrarMensaje();
            GameManager.SaveLevel = 3;
        }else if (GameManager.ScoreLaberinto == 9)
        {
            portalNextLevel.SetActive(true);
            puntaje.MostrarMensaje();
        }

        Destroy(gameObject);
    }
}
