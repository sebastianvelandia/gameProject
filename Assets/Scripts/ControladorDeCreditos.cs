using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ControladorDeCreditos : MonoBehaviour
{

    public void TerminarCreditos()
    {
        SceneManager.LoadScene("Menu");
    }
}
