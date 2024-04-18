using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Narrador : MonoBehaviour
{
    [SerializeField] private AudioClip item;
    private bool play;

    private void Awake() 
    {
        play = false;
    }

    private void Update() 
    {
        if (ControladorSonido.Instance.AudioTermino())
        {
            play = false;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (play == false)
        {
            ControladorSonido.Instance.EjecutarNarrador(item);
            play = true;
        }
        
    }

}
