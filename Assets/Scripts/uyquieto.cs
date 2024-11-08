using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uyquieto : MonoBehaviour
{
    public Vector2 originalPosition;

    private void Start()
    {
        // Guardamos la posición original del objeto al inicio del juego
        originalPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Si el objeto con el que colisionamos tiene el tag "Player",
            // movemos nuestro objeto a su posición original
            transform.position = originalPosition;
        }
    }
}
