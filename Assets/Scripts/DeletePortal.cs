using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeletePortal : MonoBehaviour
{
    private void Awake() {
        int num = GameManager.Score;

        if (num == 30)
        {
            Debug.Log("En el Awake");
            GameManager.Instance.destroyPortal();
        }
    }
}