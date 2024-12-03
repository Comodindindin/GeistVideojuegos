using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioComic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void comicP2()
	{
		SceneManager.LoadScene(8);
	}

	public void comicP3()
	{
		SceneManager.LoadScene(9);
	}

    public void escenaFinal()
    {
        SceneManager.LoadScene(10);
    }

    public void Menu()
	{
		SceneManager.LoadScene(1);
	}


}
	
