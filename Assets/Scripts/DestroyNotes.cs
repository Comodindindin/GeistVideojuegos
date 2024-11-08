using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNotes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

  private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            
            Destroy(this.gameObject);
        }
    }
}
