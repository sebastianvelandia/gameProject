using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerLaberinto : MonoBehaviour
{
    private float timer = 50;
    public TextMeshProUGUI textoTimer;
    private int minutos, segundos, centesimas;
    [SerializeField] private NextLevel nextLevel;

    private void Awake() 
    {
        string difficultyLevel = GameManager.DifficultyLevel;
        switch (difficultyLevel)
        {
            case "Facil":
                Debug.Log("Dificultad de nivel: FACIL");
                timer = 60;
                break;
            case "Medio":
                Debug.Log("Dificultad de nivel: MEDIO");
                timer = 45;
                break;
            case "Dificil":
                Debug.Log("Dificultad de nivel: DIFICIL");
                timer = 30;
                break;
        }
    }
    public void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
        }

        minutos = (int) (timer / 60f);
        segundos = (int) (timer - minutos * 60f);
        centesimas = (int) ((timer - (int) timer) * 100f);

        textoTimer.text = string.Format("{0:00}:{1:00}:{2:00}", minutos,segundos,centesimas);

        if (timer == 0)
        {
            nextLevel.PlayerDead();
        }
    }
}
 