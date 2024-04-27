using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeletePortal : MonoBehaviour
{
    [SerializeField] public List<GameObject> checkPoints;
    private void Awake() {

        bool estado = ControladorSonido.Instance.AudioTermino();

        int num = GameManager.Score;
        if (num == 30)
        {
            GameManager.Instance.DestroyPortal();
        } else 
        {
            checkPoints[0].gameObject.SetActive(false);
            checkPoints[1].gameObject.SetActive(false);
        }

        int numSalon1 = GameManager.ScoreLaberinto;
        if (numSalon1 == 3 || GameManager.SaveLevel == 2)
        {
            checkPoints[0].gameObject.SetActive(true);
            
        } else if (numSalon1 == 6 || GameManager.SaveLevel == 3)
        {
            checkPoints[0].gameObject.SetActive(true);
            checkPoints[1].gameObject.SetActive(true);
        } 
    }
}