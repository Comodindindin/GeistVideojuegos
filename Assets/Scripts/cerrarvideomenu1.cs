using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;              //Lo que reproduce el video//
using UnityEngine.SceneManagement;   //La madre esa que hace cambiar escenas uwu//

public class cerrarvideomenu1 : MonoBehaviour
{
    private VideoPlayer videos;       // Componente VideoPlayer
    private int numeroEscena = 13;    // Índice de la escena a cargar (definido directamente en el código)

    private void Awake()
    {
        // Intentar obtener automáticamente el componente VideoPlayer
        videos = GetComponent<VideoPlayer>();

        // Validar que el VideoPlayer esté configurado
        if (videos != null)
        {
            videos.Play();
            Debug.Log("Reproduciendo video...");
            videos.loopPointReached += CheckOver; // Suscribirse al evento que detecta el fin del video
        }
        else
        {
            Debug.LogError("El componente VideoPlayer no se encontró en " + gameObject.name);
        }
    }

    // Este método se llama automáticamente cuando el video termina
    void CheckOver(VideoPlayer vp)
    {
        Debug.Log("El video ha finalizado. Cambiando a la escena: " + numeroEscena);

        // Validar que el índice de la escena es válido
        if (numeroEscena >= 0 && numeroEscena < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(numeroEscena); // Cargar la escena especificada
        }
        else
        {
            Debug.LogError("Índice de escena inválido: " + numeroEscena);
        }
    }
}