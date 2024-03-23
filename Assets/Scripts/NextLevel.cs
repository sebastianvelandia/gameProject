using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] public List<GameObject> vidasJugador;
    private int totalVidasJugador;

    private void Awake() {
        totalVidasJugador = 3;
    }
    public bool RestarVida()
    {
        Debug.Log("Vidas = "+totalVidasJugador);
        if (totalVidasJugador == 1)
        {
            Debug.Log("Pierde vida 1...");
            vidasJugador[0].gameObject.SetActive(false);
            totalVidasJugador--;
            return true;
        }
        else if (totalVidasJugador == 2)
        {
            Debug.Log("Pierde vida 2...");
            vidasJugador[1].gameObject.SetActive(false);
            totalVidasJugador--;
            return false;
        }
        else if (totalVidasJugador == 3)
        {
            Debug.Log("Pierde vida 3...");
            vidasJugador[2].gameObject.SetActive(false);
            totalVidasJugador--;
            return false;
        }
        return false;
    }

}
