using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    void Start()
    {
        // Obtiene el componente SpriteRenderer y valida su existencia
        theSR = GetComponent<SpriteRenderer>();
        if (theSR == null)
        {
            Debug.LogError("SpriteRenderer no encontrado en " + gameObject.name);
        }
    }

    void Update()
    {
        // Asegura que theSR no sea nulo antes de usarlo
        if (theSR != null)
        {
            if (Input.GetKeyDown(keyToPress))
            {
                theSR.sprite = pressedImage;
            }

            if (Input.GetKeyUp(keyToPress))
            {
                theSR.sprite = defaultImage;
            }
        }
    }
}
