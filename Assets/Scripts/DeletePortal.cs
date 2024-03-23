using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeletePortal : MonoBehaviour
{
    [SerializeField] public List<GameObject> checkPoints;
    private void Awake() {
        int num = GameManager.Score;
        Debug.Log("Score Historico = " + num);
        if (num == 30)
        {
            GameManager.Instance.destroyPortal();
        }

        int numSalon1 = GameManager.ScoreLaberinto;
        Debug.Log("Score Salon 1 = " + numSalon1);
        if (numSalon1 == 3)
        {
            Debug.Log("Se activa Salon 2...");
            checkPoints[0].gameObject.SetActive(true);
        }
    }
}