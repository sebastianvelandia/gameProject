using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    private int index;
    [SerializeField] private Image imagen;
    [SerializeField] private TextMeshProUGUI nombre;
    [SerializeField] private AudioClip click;
    private GameManager gameManager;

    private void Start() {
        gameManager = GameManager.Instance;
        index = PlayerPrefs.GetInt("JugadorIndex", index);

        if (index > gameManager.personajes.Count - 1)
        {
            index = 0;
        }

        CambiarPantalla();
    }

    private void CambiarPantalla()
    {
        ControladorSonido.Instance.EjecutarSonido(click);
        PlayerPrefs.SetInt("JugadorIndex", index);
        imagen.sprite = gameManager.personajes[index].imagen;
        nombre.text = gameManager.personajes[index].nombre;
    }

    public void SiguientePersonaje()
    {
        if (index == gameManager.personajes.Count - 1)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }

        CambiarPantalla();
    }

    public void AnteriorPersonaje()
    {
        if (index == 0)
        {
            index = gameManager.personajes.Count - 1;
        }
        else
        {
            index -= 1;
        }

        CambiarPantalla();
    }

}
