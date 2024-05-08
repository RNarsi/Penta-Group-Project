using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTapped : MonoBehaviour
{
    public LayerMask tileLayer;
    public float raycastDistance = 100f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Assuming left mouse button for tap
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, raycastDistance, tileLayer);
            if (hit.collider != null)
            {
                // Get the grid position of the tapped tile
                Vector3 gridPosition = hit.collider.transform.position;

                // Check if the move is valid (implement your own logic here)
                bool isValidMove = IsMoveValid(gridPosition);

                if (isValidMove)
                {
                    // Move the piece to the tapped tile position
                    hit.collider.GetComponent<PieceMovement>().MoveTo(gridPosition);
                }
            }
        }
    }

    private bool IsMoveValid(Vector3 gridPosition)
    {
        // Implement your own validation logic here
        // For example, check if the grid position is adjacent to the current position of the piece
        // and if the grid position is empty or occupied by an opponent's piece.
        // Return true if the move is valid, false otherwise.
        return true; // Placeholder, replace with your validation logic
    }
}