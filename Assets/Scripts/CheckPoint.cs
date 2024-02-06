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
            SceneManager.LoadScene("Video 1"); 
        }else if (numCheckPoint == "2")
        {
            SceneManager.LoadScene("Lobby Salon 2");

        }else if (numCheckPoint == "3")
        {
            SceneManager.LoadScene("Lobby Salon 3");

        }else if (numCheckPoint == "4")
        {
            SceneManager.LoadScene("Lobby Universidad");

        }
        
    }
}
