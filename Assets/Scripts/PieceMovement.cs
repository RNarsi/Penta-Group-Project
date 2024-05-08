using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    private Vector3 targetPosition;
    private bool isMoving = false;
    float moveSpeed = 20;

    private void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * moveSpeed);

            if (transform.position == targetPosition)
                isMoving = false;
        }
    }

    // Call this method to initiate movement to a new position
    public void MoveTo(Vector3 newPosition)
    {
        targetPosition = newPosition;
        isMoving = true;
    }
}
