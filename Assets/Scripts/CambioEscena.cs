using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Cambiar a una escena específica por índice
    public void CambiarEscena(int indiceEscena)
    {
        if (indiceEscena >= 0 && indiceEscena < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(indiceEscena);
        }
        else
        {
            Debug.LogError("Índice de escena inválido: " + indiceEscena);
        }
    }

    // Salir de la aplicación
    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
