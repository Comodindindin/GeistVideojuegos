using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBillBoard : MonoBehaviour

{
    [SerializeField] bool freezeXZAxis = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (freezeXZAxis)

    {
        transform.rotation = Quaternion.Euler(0F, Camera.main.transform.rotation.eulerAngles.y, 0F);
    }
     else
    {
         transform.rotation = Camera.main.transform.rotation;
    }

    }







    }


