using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceDragger : MonoBehaviour
{
    private Vector2 startPosition;
    private Vector2 endPosition;
    private bool isDragging = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
            isDragging = true;
        }

        if (Input.GetMouseButtonUp(0)) 
        {
            endPosition = Input.mousePosition;  
            isDragging = false;

            //Raycast from end position to detect which block was clicked
            RaycastHit2D hit = Physics2D.Raycast(endPosition, Vector2.zero);

            if (hit.collider != null)
            {
                //move the piece to the clicked block
                transform.position = hit.transform.position;
            }
        }

        if (isDragging)
        {
            //update the piece position while dragging 
            Vector2 currentPosition = Input.mousePosition;
            transform.position = Vector2.Lerp(startPosition, currentPosition, 0.1f);
        }
    }
}
