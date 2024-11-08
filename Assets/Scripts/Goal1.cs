using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal1 : MonoBehaviour
{

    public Inventario inventario;
    // Start is called before the first frame update
    void Start()
    {
        inventario =  GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

   private void  OnTriggerEnter(Collider coll)
   {
     if(coll.gameObject.tag == "Player")
     {
     if (inventario.cantidad == 3)
     {
    
       SceneManager.LoadScene(15);

     }
         
 }
}
}
