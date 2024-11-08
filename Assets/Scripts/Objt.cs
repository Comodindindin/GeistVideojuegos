using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Objt : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public Inventario inventario;
    // Start is called before the first frame update
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }



    private void OnTriggerEnter(Collider colli)
    {
        if (colli.gameObject.tag == "Player")
        {
            inventario.cantidad = inventario.cantidad + 1;
            textMesh.text = "Lágrimas:     " + inventario.cantidad;
            Destroy(gameObject);
        }

    }
}