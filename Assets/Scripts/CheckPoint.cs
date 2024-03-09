using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    public string numCheckPoint;
    [SerializeField] private AudioClip click;
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        ControladorSonido.Instance.EjecutarSonido(click);
        StartCoroutine(waitAndLoad(1F));        
    }

    IEnumerator waitAndLoad(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        if (numCheckPoint == "1")
        {
            GameManager.EscenaAnterior = "Lobby Museo-Salon1";
            SceneManager.LoadScene("Transicion Escena");
        }else if (numCheckPoint == "2")
        {
            Debug.Log("Lobby Salon 2");

        }else if (numCheckPoint == "3")
        {
            Debug.Log("Lobby Salon 3");

        }else if (numCheckPoint == "4")
        {
            GameManager.EscenaAnterior = "Lobby Museo-Uni";
            SceneManager.LoadScene("Transicion Escena");
        }else if (numCheckPoint == "5")
        {
            SceneManager.LoadScene("Lobby Museo"); 
        }
        
    }
}
