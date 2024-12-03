using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje: MonoBehaviour
{
    Animator anime;
    public AudioSource correr;
    public float velocidad = 5f;  // Velocidad del personaje, puedes ajustarla según lo necesites

    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isMoving = false;  // Variable para verificar si hay movimiento

        // Movimiento hacia la derecha
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidad * Time.deltaTime, 0, 0);  // Moverse a la derecha
            anime.SetBool("Derecha", true);
            correr.Play();
            isMoving = true;
        }
        else
        {
            anime.SetBool("Derecha", false);
        }

        // Movimiento hacia la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidad * Time.deltaTime, 0, 0);  // Moverse a la izquierda
            anime.SetBool("Izquierda", true);
            correr.Play();
            isMoving = true;
        }
        else
        {
            anime.SetBool("Izquierda", false);
        }

        // Movimiento hacia atrás
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidad * Time.deltaTime);  // Moverse hacia atrás
            anime.SetBool("Atras", true);
            correr.Play();
            isMoving = true;
        }
        else
        {
            anime.SetBool("Atras", false);
        }

        // Movimiento hacia adelante
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidad * Time.deltaTime);  // Moverse hacia adelante
            anime.SetBool("Enfrente", true);
            correr.Play();
            isMoving = true;
        }
        else
        {
            anime.SetBool("Enfrente", false);
        }

        // Si no se está moviendo, pausamos la animación de correr
        if (!isMoving)
        {
            correr.Pause();  // Pausar el sonido de correr
        }
    }
}