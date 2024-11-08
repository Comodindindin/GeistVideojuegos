using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movertuto : MonoBehaviour


{
    Animator anime;
    public AudioSource correr;
    public SpriteRenderer miRenderer;
  
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
              transform.Translate(200f * Time.deltaTime, 0, 0);
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
              transform.Translate(-200f * Time.deltaTime, 0, 0);
                anime.SetBool("Izquierda", true);
                correr.Play();
            }
            else
            {
                anime.SetBool("Izquierda", false);
                correr.Pause();
            }
         

        }

    }
    }