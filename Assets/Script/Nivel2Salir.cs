using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel2Salir : MonoBehaviour
{

    public string sceneName1;
    public string sceneName2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Check for a match with the specified name on any GameObject that collides with your GameObject


        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene(sceneName1);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(sceneName2);
        }




    }
}
