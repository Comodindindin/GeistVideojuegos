using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    public bool terminoElJuego = false; 
    public int totalPuntaje = 0;
    private int puntajePorNota = 10; //Modifiquen esto para saber cuántos puntos tiene que darles cada nota
   
       public TextMeshProUGUI textMesh;

    public void start()
  

    {
  

    }

    public void SumarPuntos()
    {
        totalPuntaje += puntajePorNota;
         textMesh.text = "Puntaje:            " + totalPuntaje;
       Invoke("Final2",60f);
 
   }

   public  void  Fin()
   {
    if(totalPuntaje>= 600)
    {
  
       SceneManager.LoadScene(18);
    }
   }
   public  void  Final2()
   {
    if(totalPuntaje< 600 || totalPuntaje==0)
    {

     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    else
    {
        Fin();
    }
    
   }

  }

