using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLave : MonoBehaviour
{

    public GameObject player;
    public GameObject cofre;
    public GameObject oro;
    public GameObject llave;
    public GameObject llavet;
    public GameObject paredllave;



    private GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        cofre.SetActive(false);
        oro.SetActive(false);
        llavet.SetActive(false);
        llave.SetActive(true);
        paredllave.SetActive(true);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            gm.numcheck += 1;
            Destruir();
        }
    }


    void Destruir()
    {
        if (gm.numcheck == 3)
        {
            cofre.SetActive(true);
            oro.SetActive(true);
            llavet.SetActive(true);
            llave.SetActive(false);
            paredllave.SetActive(false);


        }

    }
}
