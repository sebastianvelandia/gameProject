using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLaberinto : MonoBehaviour
{
    [SerializeField] private AudioClip item;
    [SerializeField] private int objetoObtenido;
    [SerializeField] private Puntaje puntaje;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        puntaje.SumarObjetos(objetoObtenido);
        ControladorSonido.Instance.EjecutarSonido(item);
        GameManager.Instance.incScoreLaberinto(objetoObtenido);
        Destroy(gameObject);
    }
}
