using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private int objetosObtenidos;
    private TextMeshProUGUI puntajeText;
    
    private void Start() {
        puntajeText = GetComponent<TextMeshProUGUI>();
    }

    public void SumarObjetos(int objeto){
        objetosObtenidos += objeto;
        Debug.Log("Puntaje = "+objetosObtenidos);
        puntajeText.text = "Objetos obtenidos: " + objetosObtenidos + "/3";
    }
}
