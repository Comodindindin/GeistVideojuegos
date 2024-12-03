using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Cambiar a una escena específica por índice
    public void CambiarEscena(int indiceEscena)
    {
        // Obtiene el índice de la escena actual
        int indiceEscenaActual = SceneManager.GetActiveScene().buildIndex;

        // Calcula el índice de la siguiente escena
        int indiceSiguienteEscena = indiceEscenaActual + 1;

        // Verifica si la siguiente escena está dentro del rango del Build Settings
        if (indiceSiguienteEscena < SceneManager.sceneCountInBuildSettings)
        {
            // Cambia a la siguiente escena
            SceneManager.LoadScene(indiceSiguienteEscena);
        }
        else
        {
            // Si no hay más escenas, muestra un mensaje en consola
            Debug.LogError("No hay más escenas en el Build Settings.");
        }
    }

    // Salir de la aplicación
    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
