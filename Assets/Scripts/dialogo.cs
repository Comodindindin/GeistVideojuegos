using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogo : MonoBehaviour
{
    [SerializeField] private GameObject Exclamacion;   // Signo de exclamación.
    [SerializeField, TextArea(4, 6)] private string[] lineasDialogo; // Diálogos del juego.
    [SerializeField] private GameObject panelDialogo; // Referencia al panel de diálogo.
    [SerializeField] private TMP_Text dialogoTexto;   // Referencia al texto del diálogo.

    private float typingTime = 0.05f;   // Tiempo de escritura del texto.
    private bool isPlayerInRange;       // Si el jugador está cerca.
    private bool didDialogueStart;      // Si el diálogo ha comenzado.
    private int lineIndex;              // Índice de la línea del diálogo actual.

    void Start()
    {
        // Validar que todas las referencias estén asignadas
        if (Exclamacion == null)
        {
            Debug.LogError("El campo 'Exclamacion' no está asignado en el Inspector.");
        }
        if (panelDialogo == null)
        {
            Debug.LogError("El campo 'panelDialogo' no está asignado en el Inspector.");
        }
        if (dialogoTexto == null)
        {
            Debug.LogError("El campo 'dialogoTexto' no está asignado en el Inspector.");
        }
    }

    void Update()
    {
        // Mostrar diálogo al hacer clic izquierdo (Fire1).
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            if (!didDialogueStart)
            {
                Debug.Log("Iniciando diálogo...");
                StartDialogue();  // Comienza el diálogo si no ha iniciado.
            }
            else if (dialogoTexto.text == lineasDialogo[lineIndex])
            {
                Debug.Log("Mostrando siguiente línea del diálogo...");
                NextDialogueLine();  // Avanza a la siguiente línea si el texto se completó.
            }
        }

        // Saltar el diálogo con la tecla "H".
        if (didDialogueStart && Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Saltando diálogo...");
            SkipDialogue();  // Salta el diálogo al presionar "H".
        }

        // Ocultar el diálogo con la tecla "X".
        if (didDialogueStart && Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Cerrando diálogo...");
            ExitDialogue();  // Cierra el diálogo y oculta el UI al presionar "X".
        }
    }

    private void StartDialogue()
    {
        if (panelDialogo == null || dialogoTexto == null || lineasDialogo == null)
        {
            Debug.LogError("No se puede iniciar el diálogo: falta alguna referencia en el Inspector.");
            return;
        }

        didDialogueStart = true;              // Marca el inicio del diálogo.
        panelDialogo.SetActive(true);         // Muestra el panel de diálogo.
        Exclamacion.SetActive(false);         // Desactiva el signo de exclamación.
        lineIndex = 0;                        // Resetea el índice de la línea.
        StartCoroutine(ShowLine());           // Muestra la primera línea.
    }

    private void NextDialogueLine()
    {
        lineIndex++;   // Avanza al siguiente índice de diálogo.
        if (lineIndex < lineasDialogo.Length)
        {
            StartCoroutine(ShowLine());  // Muestra la siguiente línea.
        }
        else
        {
            ExitDialogue();  // Finaliza el diálogo si no hay más líneas.
        }
    }

    private IEnumerator ShowLine()
    {
        dialogoTexto.text = string.Empty;   // Limpia el texto del diálogo.
        foreach (char ch in lineasDialogo[lineIndex])
        {
            dialogoTexto.text += ch; // Agrega cada carácter al texto.
            yield return new WaitForSeconds(typingTime);  // Espera un tiempo para el siguiente carácter.
        }
    }

    private void SkipDialogue()
    {
        StopAllCoroutines();  // Detiene cualquier corrutina en ejecución.
        dialogoTexto.text = lineasDialogo[lineIndex];  // Muestra el texto completo de la línea actual.
        NextDialogueLine();  // Avanza a la siguiente línea inmediatamente.
    }

    private void ExitDialogue()
    {
        didDialogueStart = false;  // Marca el fin del diálogo.
        panelDialogo.SetActive(false);  // Oculta el panel de diálogo.
        Exclamacion.SetActive(true);    // Muestra el signo de exclamación.
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // Comprueba si el jugador entra en el área del trigger.
        {
            isPlayerInRange = true;
            Exclamacion.SetActive(true);  // Muestra el signo de exclamación.
            Debug.Log("Jugador dentro del área.");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // Comprueba si el jugador sale del área del trigger.
        {
            isPlayerInRange = false;
            Exclamacion.SetActive(false);  // Oculta el signo de exclamación.
            Debug.Log("Jugador fuera del área.");
        }
    }
}