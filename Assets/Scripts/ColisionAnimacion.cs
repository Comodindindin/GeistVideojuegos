using UnityEngine;

public class ColisionAnimacion : MonoBehaviour
{
    public Animator animator; // Referencia al componente Animator del objeto que contiene la animación

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObjetoColision")) // Comprueba si el objeto que colisionó tiene la etiqueta "ObjetoColision"
        {
            animator.SetTrigger("ActivarAnimacion"); // Activa la animación utilizando el disparador "ActivarAnimacion" en el Animator
        }
    }
}