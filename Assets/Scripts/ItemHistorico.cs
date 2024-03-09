using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemHistorico : MonoBehaviour
{
    [SerializeField] private AudioClip item;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ControladorSonido.Instance.EjecutarSonido(item);
        Destroy(gameObject);
        GameManager.Instance.incScore(10);
    }

}
