using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PtsText : MonoBehaviour
{


    public TextMeshProUGUI textMesh;
    int puntaje = 0;

    // Start is called before the first frame update
    void Start()
    {

      
    }

    private void OnCollisionEnter2D(Collision2D collision)
     {
        if (collision.gameObject.tag == "Activator"){
            puntaje = puntaje + 1;
            Destroy(collision.gameObject);
            textMesh.text = "Puntaje: " + puntaje;
            
        }
     }  
     }