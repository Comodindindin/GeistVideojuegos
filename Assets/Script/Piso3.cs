using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso3 : MonoBehaviour
{
    public GameObject totem3;
    public GameObject piso3;
    public GameObject player;
    public GameObject trest;

    private GameManager gm;


    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        trest.SetActive(false);
        piso3.SetActive(false);
        totem3.SetActive(true);


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
        if (gm.numcheck == 9)
        {
            trest.SetActive(true);
            piso3.SetActive(true);
            totem3.SetActive(false);

        }

    }
}
