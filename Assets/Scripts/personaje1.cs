using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje1: MonoBehaviour
{
    Animator anime;
    public AudioSource correr;

    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.D))
            {
             transform.Translate(25f * Time.deltaTime, 0, 0);
                anime.SetBool("Derecha", true);
                correr.Play();
            }
            else
            {
                anime.SetBool("Derecha", false);
                //correr.Pause();
            }
           
            if (Input.GetKey(KeyCode.A))
            {
            transform.Translate(-25f * Time.deltaTime, 0, 0);
                anime.SetBool("Izquierda", true);
                correr.Play();
            }
            else
            {
                anime.SetBool("Izquierda", false);
               // correr.Pause();
            }
           

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 25f * Time.deltaTime, 0);
                anime.SetBool("Atras", true);
                //correr.Play();
            }
            else
            {
             anime.SetBool("Atras", false);
                //correr.Pause();

            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -25f * Time.deltaTime, 0);
                anime.SetBool("Enfrente", true);
                correr.Play();
            }
            else
            {
             anime.SetBool("Enfrente", false);
                //correr.Pause();
            }





        }




    }







}
