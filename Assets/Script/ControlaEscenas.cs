using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlaEscenas : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void nivel1()
    {
        SceneManager.LoadScene(1);
    }

    public void nivel2()
    {
        SceneManager.LoadScene(2);
    }

    public void salir()
    {
        Application.Quit();
    }
}
