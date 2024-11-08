using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class DropZone1 : MonoBehaviour
{
    // Reference to the draggable object that is currently being dragged.
    private GameObject draggableObject1;

    // Offset between the center of the draggable object and the position where it was dropped.
    private Vector2 offset;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger has the "Draggable" tag.
        if (other.CompareTag("Drag"))
        {
            // Save a reference to the draggable object.
            draggableObject1 = other.gameObject;

            // Calculate the offset between the center of the draggable object and the position where it was dropped.
            offset = (Vector2)draggableObject1.transform.position - (Vector2)transform.position;

            // Disable the draggable object's Rigidbody2D component.
            Rigidbody2D draggableRigidbody = draggableObject1.GetComponent<Rigidbody2D>();
            if (draggableRigidbody != null)
            {
                draggableRigidbody.simulated = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Check if the draggable object is still inside the trigger.
        if (other.gameObject == draggableObject1)
        {
            // Set the position of the draggable object to the position of the drop zone plus the offset.
            draggableObject1.transform.position = (Vector2)transform.position + offset;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the draggable object has exited the trigger.
        if (other.gameObject == draggableObject1)
        {
            // Re-enable the draggable object's Rigidbody2D component.
            Rigidbody2D draggableRigidbody = draggableObject1.GetComponent<Rigidbody2D>();
            if (draggableRigidbody != null)
            {
                draggableRigidbody.simulated = true;
            }

            // Reset the reference to the draggable object.
            draggableObject1 = null;
        }
    }
}

