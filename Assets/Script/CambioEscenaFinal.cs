using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class CambioEscenaFinal : MonoBehaviour
{
    public string sceneName; // Nombre de la escena a cargar

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entra en el collider es el jugador
        if (other.CompareTag("Player"))
        {
            // Cambia a la escena especificada
            SceneManager.LoadScene(sceneName);
        }
    }
}
