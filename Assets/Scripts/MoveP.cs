using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveP : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.W))
    	{
    		transform.Translate(0,0.07f,0);
    	}
    	

         if(Input.GetKey(KeyCode.S))
    	{
    		transform.Translate(0,-0.07f,0);

    	}
    	if(Input.GetKey(KeyCode.D))
    	{
    		//transform.Translate(0.3f,0,0,Space.World);
    	
    			transform.Translate(-0.2f,0,0);

    		
    		
    	}
        if(Input.GetKey(KeyCode.A))
    	{
    	
    		
    			transform.Translate(0.2f,0,0);

    		
    		
    	}
  
    
  
}
     
}

