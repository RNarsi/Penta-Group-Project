using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceScript : MonoBehaviour
{
    public Vector2 piecePosition;           // store piece postion on board
    public BoardScript targetBoard;         //store the target block to move to

    // Update is called once per frame
    void Update()
    {
        //add movement logic here later
    }

    void MoveTOBlock(BoardScript targetBoard)
    {
        //move pieces to the target block
        transform.position = targetBoard.transform.position;
        piecePosition = targetBoard.blockPosition;
    }
}
