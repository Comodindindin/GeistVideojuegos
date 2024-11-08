using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes3 : MonoBehaviour
{
    public GameObject cristal3;
    public GameObject pared3;
    public GameObject player;
    public GameObject tresc;


    private GameManager gm;

    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        tresc.SetActive(false);

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
        if (gm.numcheck == 4)
        {
            cristal3.SetActive(false);
            pared3.SetActive(false);

            tresc.SetActive(true);

        }
    }
}
