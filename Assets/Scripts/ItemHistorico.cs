using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemHistorico : MonoBehaviour
{
    [SerializeField] private AudioClip item;
    [SerializeField] private Puntaje puntaje;
    [SerializeField] private int objetoObtenido;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ControladorSonido.Instance.EjecutarSonido(item);
        Destroy(gameObject);
        puntaje.SumarObjetos(objetoObtenido);
        GameManager.Instance.IncScore(10);

        if (GameManager.Score == 30)
        {
            puntaje.MostrarMensajeHistorico();
        }
    }

}
