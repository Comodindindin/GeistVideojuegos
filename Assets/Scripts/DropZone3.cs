using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class DropZone3 : MonoBehaviour
{
    // Reference to the draggable object that is currently being dragged.
    private GameObject draggableObject3;

    // Offset between the center of the draggable object and the position where it was dropped.
    private Vector2 offset;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger has the "Draggable" tag.
        if (other.CompareTag("Drg"))
        {
            // Save a reference to the draggable object.
            draggableObject3 = other.gameObject;

            // Calculate the offset between the center of the draggable object and the position where it was dropped.
            offset = (Vector2)draggableObject3.transform.position - (Vector2)transform.position;

            // Disable the draggable object's Rigidbody2D component.
            Rigidbody2D draggableRigidbody = draggableObject3.GetComponent<Rigidbody2D>();
            if (draggableRigidbody != null)
            {
                draggableRigidbody.simulated = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Check if the draggable object is still inside the trigger.
        if (other.gameObject == draggableObject3)
        {
            // Set the position of the draggable object to the position of the drop zone plus the offset.
            draggableObject3.transform.position = (Vector2)transform.position + offset;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the draggable object has exited the trigger.
        if (other.gameObject == draggableObject3)
        {
            // Re-enable the draggable object's Rigidbody2D component.
            Rigidbody2D draggableRigidbody = draggableObject3.GetComponent<Rigidbody2D>();
            if (draggableRigidbody != null)
            {
                draggableRigidbody.simulated = true;
            }

            // Reset the reference to the draggable object.
            draggableObject3 = null;
        }
    }
}

