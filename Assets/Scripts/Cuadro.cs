using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class Cuadro : MonoBehaviour
{
    [SerializeField] private GameObject visualMark;
    [SerializeField] private GameObject canvaCuadro;
    public int indexCuadro;
    public List<GameObject> cuadrosZoom;
    private bool isPlayerInRange;
    [SerializeField] private AudioClip click;

    void Update()
    {
        if (isPlayerInRange && Input.GetMouseButtonDown(0))
        {
            ControladorSonido.Instance.EjecutarSonido(click);
            ZoomCuadro();
        } 
    }

    private void ZoomCuadro()
    {
        int cont = 0;
        foreach (GameObject cuadro in cuadrosZoom)
        {
            if (indexCuadro == cont)
            {
                visualMark.SetActive(false);
                canvaCuadro.SetActive(true);
                cuadro.SetActive(true);
                Time.timeScale = 0;
            } else
            {
                cuadro.SetActive(false);
            }
            cont++;
        }
    }

    public void CerrarZoomCuadro()
    {
        visualMark.SetActive(true);
        canvaCuadro.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerInRange = true;
        visualMark.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerInRange = false;
        visualMark.SetActive(false);
    }
}
