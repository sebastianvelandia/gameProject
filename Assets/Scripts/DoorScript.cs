using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Open", true);
        Debug.Log("Estudiante abre la puerta");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Open", false);
        Debug.Log("Estudiante cierra la puerta");
    }

    public void ChangeScene()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            Debug.Log("Estudiante quiere regresar al Lobby Museo");
            SceneManager.LoadScene("Lobby Museo");

        }
    }

}
