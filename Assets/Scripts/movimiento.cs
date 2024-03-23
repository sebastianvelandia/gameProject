using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimiento : MonoBehaviour
{
    public float runSpeed;    
    private Vector2 direccion;
    public SpriteRenderer SpriteRenderer;
    public Animator animator;
    private Rigidbody2D rb2D;
    private Vector3 posicionInicial;
    
    
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
    }
    
    private void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized;
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            SpriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        } else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            SpriteRenderer.flipX = true;
            animator.SetBool("Run", true);

        }else if (Input.GetKey("w") || Input.GetKey("up"))
        {
            animator.SetBool("Run", true);

        }else if (Input.GetKey("s") || Input.GetKey("down"))
        {
            animator.SetBool("Run", true);

        } else {
            animator.SetBool("Run", false);
        }
        
        
    }

    private void FixedUpdate(){
        rb2D.MovePosition(rb2D.position + direccion * runSpeed * Time.fixedDeltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        if (collision.CompareTag("Enemigo"))
        {
            StartCoroutine(TransicionPosicionInicial());
        }
    }


    IEnumerator TransicionPosicionInicial()
    {
        // Define la duración de la transición (en segundos)
        float duracionTransicion = 1.0f;

        // Guarda la posición actual del jugador
        Vector3 posicionActual = transform.position;

        // Define el tiempo inicial
        float tiempoInicio = Time.time;

        // Interpolación mientras el tiempo de la transición esté en curso
        while (Time.time - tiempoInicio < duracionTransicion)
        {
            // Calcula el progreso de la transición (0 a 1)
            float progreso = (Time.time - tiempoInicio) / duracionTransicion;

            // Interpola suavemente entre la posición actual y la posición inicial
            transform.position = Vector3.Lerp(posicionActual, posicionInicial, progreso);

            // Espera al siguiente frame
            yield return null;
        }

        // Asegura que la posición sea exactamente la inicial al final de la transición
        transform.position = posicionInicial;
    }
}
