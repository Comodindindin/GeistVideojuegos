using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    Animator anime;
    //public AudioSource correr;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.D))
            {
                //correr.Play();
                transform.Translate(-14f* Time.deltaTime, 0, 0);
                
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(14f* Time.deltaTime, 0, 0);
                //correr.Play();
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0,-14f * Time.deltaTime);
               // correr.Play();
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, 14f* Time.deltaTime);
                //correr.Play();
            }












        }
    }
}