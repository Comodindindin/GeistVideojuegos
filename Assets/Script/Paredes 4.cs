using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes4 : MonoBehaviour
{
    public GameObject cristal4;
    public GameObject pared4;
    public GameObject player;
    public GameObject cuatroc;


    private GameManager gm;

    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        cuatroc.SetActive(false);

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
        if (gm.numcheck == 5)
        {
            cristal4.SetActive(false);
            pared4.SetActive(false);

            cuatroc.SetActive(true);

        }
    }
}
