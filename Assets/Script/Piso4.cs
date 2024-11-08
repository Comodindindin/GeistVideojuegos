using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso4 : MonoBehaviour
{
    public GameObject totem4;
    public GameObject piso4;
    public GameObject player;
    public GameObject cuatrot;

    private GameManager gm;


    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        cuatrot.SetActive(false);
        piso4.SetActive(false);
        totem4.SetActive(true);


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
        if (gm.numcheck == 10)
        {
            cuatrot.SetActive(true);
            piso4.SetActive(true);
            totem4.SetActive(false);

        }

    }
}
