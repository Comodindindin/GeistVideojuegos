using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso1 : MonoBehaviour
{
    public GameObject totem1;
    public GameObject piso1;
    public GameObject player;
    public GameObject unot;

    private GameManager gm;


    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        unot.SetActive(false);
        piso1.SetActive(false);
        totem1.SetActive(true);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            gm.numcheck += 1;
            Destruirp();
        }
    }


    void Destruirp()
    {
        if (gm.numcheck == 7)
        {
            unot.SetActive(true);
            piso1.SetActive(true);
            totem1.SetActive(false);

        }

    }
}
