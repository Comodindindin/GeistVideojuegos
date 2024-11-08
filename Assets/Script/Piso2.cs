using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso2 : MonoBehaviour
{
    public GameObject totem2;
    public GameObject piso2;
    public GameObject player;
    public GameObject dost;

    private GameManager gm;


    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        dost.SetActive(false);
        piso2.SetActive(false);
        totem2.SetActive(true);


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
        if (gm.numcheck == 8)
        {
            dost.SetActive(true);
            piso2.SetActive(true);
            totem2.SetActive(false);

        }

    }
}
