using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroll : MonoBehaviour
{
    public float beatTempo; // Velocidad del desplazamiento
    public bool hasStarted; // Controla si el juego ha iniciado

    void Start()
    {
        // Convierte el beatTempo a unidades por segundo
        beatTempo /= 60f;
    }

    void Update()
    {
        if (!hasStarted)
        {
            // Comienza el juego si se presiona cualquier tecla
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
        }
        else
        {
            // Mueve el objeto hacia abajo mientras el juego esté activo
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
