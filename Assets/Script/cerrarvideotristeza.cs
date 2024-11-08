using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;              //Lo que reproduce el video//
using UnityEngine.SceneManagement;   //La madre esa que hace cambiar escenas uwu//

public class cerrarvideotristeza : MonoBehaviour
{
    public VideoPlayer videos;

    private void Awake()
    {
        videos = GetComponent<VideoPlayer>();
        videos.Play();
        videos.loopPointReached += CheckOver;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckOver(VideoPlayer vp)
    {
        SceneManager.LoadScene(11);    //El numero de la escena, pero no le puse el Void ya que debe ser automatico c://
    }


}