using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorSonido : MonoBehaviour
{
    public static ControladorSonido Instance;
    private AudioSource audioSource;
    private AudioSource audioNarrador;
    private AudioSource audioClip;

    private void Awake() {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.5f;
    }

    public void EjecutarSonido(AudioClip sonido)
    {
        audioClip = GetComponent<AudioSource>();
        audioClip.PlayOneShot(sonido);
    }
    public void EjecutarNarrador(AudioClip sonido)
    {
        audioSource.Stop();
        audioNarrador = GetComponent<AudioSource>();
        audioNarrador.PlayOneShot(sonido);
    }
    public bool AudioTermino()
    {
        if (audioNarrador != null)
        {
            if (!audioNarrador.isPlaying)
            {
                audioSource.Play();
                Debug.Log("El audio ha terminado de reproducirse.");
                return true;
            } else if (SceneManager.GetActiveScene().name != "Lobby Historico"){
                audioNarrador.Stop();
                audioSource.Play();
            }
        } else {
            return false;
        }
        return false;
    }

}
