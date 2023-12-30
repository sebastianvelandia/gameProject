using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public Animator animator;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Open", true);
            Debug.Log("Estudiante abre la puerta");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {   
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Open", false);
            Debug.Log("Estudiante cierra la puerta");     
        }
        
    }

    public void ChangeScene()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            Debug.Log("Estudiante quiere regresar al Lobby Universidad");
            StartCoroutine(waitAndLoad(0.2F));
            
        }
    }

    IEnumerator waitAndLoad(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Lobby Universidad"); 
    }
}
