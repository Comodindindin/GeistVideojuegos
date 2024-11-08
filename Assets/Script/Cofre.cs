using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    public GameObject player;
    public GameObject cofre;
    public GameObject nivel2;
    public GameObject nivel2bot;



    private GameManager gm;


    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        nivel2.SetActive(false);
        nivel2bot.SetActive(false);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            gm.numcheck += 1;
            Cambio();
        }
    }


    void Cambio()
    {
        if (gm.numcheck == 11)
        {
        nivel2.SetActive(true);
        nivel2bot.SetActive(true);


        }

    }
}
