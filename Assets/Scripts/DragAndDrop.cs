
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 startPosition;
    private float distance;

    public Vector3 offset;

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        isDragging = true;
        startPosition = transform.position;
    }

    void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 rayPoint = ray.GetPoint(distance);
        transform.position = new Vector3(rayPoint.x, rayPoint.y, transform.position.z);
    }

 void OnMouseUp()
{
    isDragging = false;
    RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero);
    if (hit.collider != null && hit.collider.tag == "DropZone")
    {
        transform.position = hit.collider.gameObject.transform.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, startPosition.z); // establecer en el centro del objeto de destino
        transform.localScale = hit.collider.gameObject.transform.localScale;
      

    }
    else
    {
        transform.position = startPosition;
    }
}
}