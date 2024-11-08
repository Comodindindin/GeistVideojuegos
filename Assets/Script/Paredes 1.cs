using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes1 : MonoBehaviour
{
    public GameObject cristal1;
    public GameObject pared1;
    public GameObject player;
    public GameObject unoc;

    private GameManager gm;

    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        unoc.SetActive(false);
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
        if (gm.numcheck == 1)
        {
            cristal1.SetActive(false);
            pared1.SetActive(false);

            unoc.SetActive(true);
        }
                
    }   

}
