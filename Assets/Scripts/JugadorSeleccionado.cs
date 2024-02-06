using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class JugadorSeleccionado : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachineVirtualCamera;

    public List<GameObject> jugadoresPrefab;

    private void Start()
    {
        int indexJugador = PlayerPrefs.GetInt("JugadorIndex");
        GameObject jugador = null;
        if (SceneManager.GetActiveScene().name == "Lobby Universidad")
        {
            jugador = Instantiate(GameManager.Instance.personajes[indexJugador].personajeJugable, transform.position, Quaternion.identity);
            cinemachineVirtualCamera.Follow = jugador.transform;
        }
        else if (SceneManager.GetActiveScene().name == "Lobby Museo")
        {
            Instantiate(JugadorPrefab(indexJugador), transform.position, Quaternion.identity);
        }
        else if (SceneManager.GetActiveScene().name == "Lobby Salon 1" || SceneManager.GetActiveScene().name == "Lobby Salon 2" || SceneManager.GetActiveScene().name == "Lobby Salon 3")
        {
            Instantiate(JugadorPrefab(indexJugador), transform.position, Quaternion.identity);
        }

    }

    private GameObject JugadorPrefab(int index)
    {
        GameObject jugadorPrefab = null;
        if (index == 0)
        {
            jugadorPrefab = jugadoresPrefab[0];
        } 
        else if (index == 1)
        {
            jugadorPrefab = jugadoresPrefab[1];
        }
        else if (index == 2)
        {
            jugadorPrefab = jugadoresPrefab[2];
        }

        return jugadorPrefab;
    }
}
