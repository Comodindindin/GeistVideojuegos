using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Para cambiar escenas

    public void Escena0()
    {
        SceneManager.LoadScene(0);
    }

    public void Escena1()
    {
        SceneManager.LoadScene(1);
    }

    public void Escena2()
    {
        SceneManager.LoadScene(2);
    }

     public void Escena3()
    {
        SceneManager.LoadScene(3);
    }

     public void Escena15()
    {
        SceneManager.LoadScene(15);
    }
    public void Escena21()
    {
        SceneManager.LoadScene(21);
    }


    public void Escena20()
    {
        SceneManager.LoadScene(20);
    }

    public void Escena19()
    {
        SceneManager.LoadScene(19);
    }


    public void salir()
    {
        Application.Quit();
    }



}
