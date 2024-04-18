using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    private void Start() 
    {
        StartCoroutine(CargarEscena(5F));
    }

    private IEnumerator CargarEscena(float time)
    {
        yield return new WaitForSecondsRealtime(time);
                
        SceneManager.LoadScene("Menu");
    }
}