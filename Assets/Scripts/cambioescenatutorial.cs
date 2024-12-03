using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;              //Lo que reproduce el video//
using UnityEngine.SceneManagement;   //La madre esa que hace cambiar escenas uwu//


public class cambioescenatutorial : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Componente VideoPlayer
    public int numeroEscena;        // Índice de la escena a cargar

    private void Awake()
    {
        // Obtener el componente VideoPlayer si no se asignó en el inspector
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // Validar que el VideoPlayer esté configurado
        if (videoPlayer != null)
        {
            videoPlayer.Play();
            Debug.Log("Reproduciendo video...");
            videoPlayer.loopPointReached += CheckOver; // Suscribirse al evento de finalización
        }
        else
        {
            Debug.LogError("VideoPlayer no encontrado en el objeto: " + gameObject.name);
        }
    }

    // Este método se ejecuta cuando el video termina
    void CheckOver(VideoPlayer vp)
    {
        Debug.Log("Video finalizado. Cambiando a la escena: " + numeroEscena);
        if (numeroEscena >= 0 && numeroEscena < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(numeroEscena); // Cambiar a la escena especificada
        }
        else
        {
            Debug.LogError("Índice de escena inválido: " + numeroEscena);
        }
    }
}
