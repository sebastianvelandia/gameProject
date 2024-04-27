using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class dialogue : MonoBehaviour
{
    [SerializeField] private GameObject dialogueMark;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;
    [SerializeField] private AudioClip click;
    private float typingTime = 0.05f;

    private bool isPlayerInRange;
    private bool didDialogueStart;

    private int lineIndex;

    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            ControladorSonido.Instance.EjecutarSonido(click);
            if (!didDialogueStart)
            {
                StartDialogue();
            }
            else if (dialogueText.text == dialogueLines[lineIndex])
            {
                NextDialogueLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogueLines[lineIndex];
            }
        }

    }

    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        dialogueMark.SetActive(false);
        lineIndex = 0;
        Time.timeScale = 0f;
        StartCoroutine(ShowLine());
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            dialogueMark.SetActive(true);
            GameManager.EscenaAnterior = "Lobby Universidad";
            SceneManager.LoadScene("Transicion Escena");
            Time.timeScale = 1f;

        }
    }

    private IEnumerator ShowLine()
    {

        dialogueText.text = string.Empty;

        foreach (char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerInRange = true;
        dialogueMark.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerInRange = false;
        dialogueMark.SetActive(false);
    }
}

