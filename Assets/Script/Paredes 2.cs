using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes2 : MonoBehaviour
{
    public GameObject cristal2;
    public GameObject pared2;
    public GameObject player;
    public GameObject dosc;

    private GameManager gm;

    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        dosc.SetActive(false);
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
        if (gm.numcheck == 2)
        {
            cristal2.SetActive(false);
            pared2.SetActive(false);
            dosc.SetActive(true);
        }
    }
}
