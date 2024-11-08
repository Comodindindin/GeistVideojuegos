using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class reprod : MonoBehaviour
{
	private VideoPlayer iniciar;
    public AudioSource music;
    

    
    // Start is called before the first frame update
    void Start()
    {
       iniciar=GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ejecuta()
    {
    	iniciar.Play();
    	music.Play();

      
    }
    public void detiene()
    {
    	iniciar.Stop();
        music.Play();
    }
}

