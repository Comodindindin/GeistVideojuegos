using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class DropZone2 : MonoBehaviour
{
    // Reference to the draggable object that is currently being dragged.
    private GameObject draggableObject2;

    // Offset between the center of the draggable object and the position where it was dropped.
    private Vector2 offset;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger has the "Draggable" tag.
        if (other.CompareTag("Dragg"))
        {
            // Save a reference to the draggable object.
            draggableObject2 = other.gameObject;

            // Calculate the offset between the center of the draggable object and the position where it was dropped.
            offset = (Vector2)draggableObject2.transform.position - (Vector2)transform.position;

            // Disable the draggable object's Rigidbody2D component.
            Rigidbody2D draggableRigidbody = draggableObject2.GetComponent<Rigidbody2D>();
            if (draggableRigidbody != null)
            {
                draggableRigidbody.simulated = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Check if the draggable object is still inside the trigger.
        if (other.gameObject == draggableObject2)
        {
            // Set the position of the draggable object to the position of the drop zone plus the offset.
            draggableObject2.transform.position = (Vector2)transform.position + offset;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the draggable object has exited the trigger.
        if (other.gameObject == draggableObject2)
        {
            // Re-enable the draggable object's Rigidbody2D component.
            Rigidbody2D draggableRigidbody = draggableObject2.GetComponent<Rigidbody2D>();
            if (draggableRigidbody != null)
            {
                draggableRigidbody.simulated = true;
            }

            // Reset the reference to the draggable object.
            draggableObject2 = null;
        }
    }
}

