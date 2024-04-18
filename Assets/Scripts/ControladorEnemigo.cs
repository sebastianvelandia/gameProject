using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEnemigo : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Transform controladorEnfrente;
    [SerializeField] private float distanciaAbajo;
    [SerializeField] private float distanciaEnfrente;
    [SerializeField] private bool moviendoDerecha;
    [SerializeField] private Animator animator;
    [SerializeField] private NextLevel nextLevel;
    private bool colisionActiva = false;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate() {
        RaycastHit2D informacionSuelo = Physics2D.Raycast(controladorSuelo.position,Vector2.down,distanciaAbajo);
        rb.velocity = new Vector2(velocidad,rb.velocity.y);

        if (informacionSuelo == false)
        {
            Girar();
        }
    }

    private void Girar()
    {
        moviendoDerecha = !moviendoDerecha;
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y + 180, 0);
        velocidad  *= -1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(controladorSuelo.position, controladorSuelo.transform.position + Vector3.down * distanciaAbajo);
        Gizmos.DrawLine(controladorSuelo.position, controladorSuelo.transform.position + Vector3.right * distanciaEnfrente);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Jugador") && !colisionActiva)
        {
            Debug.Log("Colision con Jugador...");
            colisionActiva = true;
            animator.SetBool("golpe", true);
            bool estado = nextLevel.RestarVida();
            StartCoroutine(ResetearColisionActiva(1f));
            if (estado)
            {
                nextLevel.PlayerDead();
            }
            else{
                Debug.Log("Jugador sigue vivo...");
            }
            // Girar();
        }
    }

    private IEnumerator ResetearColisionActiva(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        colisionActiva = false;
    }

    public void FinGolpe()
    {
        animator.SetBool("golpe", false);
    }

}
