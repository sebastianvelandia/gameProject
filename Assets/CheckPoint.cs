using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    public string numCheckPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        StartCoroutine(waitAndLoad(0.8F));        
    }

    IEnumerator waitAndLoad(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        if (numCheckPoint == "1")
        {
            SceneManager.LoadScene("Lobby Salon"); 
        }else if (numCheckPoint == "2")
        {
            SceneManager.LoadScene("Lobby Salon 1");

        }else if (numCheckPoint == "3")
        {
            SceneManager.LoadScene("Lobby Salon 2");

        }
        
    }
}
