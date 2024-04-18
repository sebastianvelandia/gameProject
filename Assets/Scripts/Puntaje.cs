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
        puntajeText.text = "- Objetos obtenidos: " + objetosObtenidos + "/3";
    }

    public void MostrarMensaje(){
        puntajeText.text = "- Objetos obtenidos: " + objetosObtenidos + "/3.\n"+
        "- Ve al portal que esta abajo a la derecha.";
    }

    public void MostrarMensajeHistorico(){
        puntajeText.text = "- Objetos obtenidos: " + objetosObtenidos + "/3.\n"+
        "- Ve al portal.";
    }
}
