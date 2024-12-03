using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class dialogoalegriacaminar : MonoBehaviour
{
    [SerializeField] private GameObject Exclamacion;   // Signo de exclamación.
    [SerializeField, TextArea(4, 6)] private string[] lineasdialogo;  // Variable para guardar los diálogos.
    [SerializeField] private GameObject paneldialogo;  // Referencia para llamar al panel.
    [SerializeField] private TMP_Text dialogotext;     // Referencia al texto del diálogo.

    private Animator anime;

    private float typingTime = 0.05f;   // Tiempo de escritura del texto.
    private bool isPlayerInRange;       // Si el jugador está cerca.
    private bool didDialogueStart;      // Si el diálogo ha comenzado.
    private int lineIndex;              // Índice de la línea del diálogo actual.

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))   // Al presionar el botón "Fire1" (click izquierdo)
        {
            if (!didDialogueStart) // Si el diálogo no ha comenzado
            {
                StartDialogue();  // Comienza el diálogo.
            }
            else if (dialogotext.text == lineasdialogo[lineIndex])
            {
                NextDialogueLine();  // Avanza al siguiente diálogo.
            }
        }

        // Permite saltar el diálogo con la tecla "H".
        if (didDialogueStart && Input.GetKeyDown(KeyCode.H))
        {
            SkipDialogue();  // Salta al siguiente diálogo inmediatamente.
        }
    }

    private void StartDialogue()
    {
        Debug.Log("Dialogo corriendo");
        didDialogueStart = true;              // Marca el inicio del diálogo.
        paneldialogo.SetActive(true);         // Muestra el panel de diálogo.
        Exclamacion.SetActive(false);         // Desactiva el signo de exclamación.
        lineIndex = 0;                        // Resetea el índice de la línea.
        StartCoroutine(ShowLine());           // Muestra la primera línea del diálogo.

        anime = gameObject.GetComponent<Animator>();
    }

    private void NextDialogueLine()
    {
        lineIndex++;   // Avanza al siguiente índice de diálogo.
        if (lineIndex < lineasdialogo.Length)
        {
            StartCoroutine(ShowLine());  // Muestra la siguiente línea.
        }
        else
        {
            didDialogueStart = false;   // Termina el diálogo.
            paneldialogo.SetActive(false);  // Oculta el panel de diálogo.
            Exclamacion.SetActive(true);    // Muestra el signo de exclamación.

            anime.SetTrigger("Acaminar");  // Dispara la animación de caminar.
        }
    }

    private IEnumerator ShowLine()
    {
        dialogotext.text = string.Empty;   // Limpia el texto del diálogo.
        foreach (char ch in lineasdialogo[lineIndex])
        {
            dialogotext.text += ch; // Agrega cada carácter al texto.
            yield return new WaitForSeconds(typingTime);  // Espera un tiempo antes de mostrar el siguiente carácter.
        }
    }

    private void SkipDialogue()
    {
        StopAllCoroutines();  // Detiene todas las corrutinas en ejecución.
        dialogotext.text = lineasdialogo[lineIndex];  // Muestra el texto completo de la línea actual.
        NextDialogueLine();  // Avanza a la siguiente línea inmediatamente.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Soul")  // Verifica si el jugador entra en el área del trigger.
        {
            isPlayerInRange = true;
            Exclamacion.SetActive(true);  // Muestra el signo de exclamación.
            Debug.Log("Funciona");  // Mensaje para verificar el funcionamiento.
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Soul")  // Verifica si el jugador sale del área del trigger.
        {
            isPlayerInRange = false;
            Exclamacion.SetActive(false);  // Oculta el signo de exclamación.
            Debug.Log("Ya no genera");  // Mensaje para verificar el funcionamiento.
        }
    }
}