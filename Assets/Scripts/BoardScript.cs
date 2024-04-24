using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    public Vector2 blockPosition;
    //stores the size of the board(7x7)
    public int boardSizeX = 7;
    public int boardSizeY = 7;

   //Store the block game objects in a 2D array
    public GameObject[,] blocks;

    // Start is called before the first frame update
    void Start()
    {
        //initialize the block array
        blocks = new GameObject[boardSizeX, boardSizeY];

        //loop through all child blocks and store them in an array
        for (int x = 0; x < boardSizeX; x++)
        {
            for (int y = 0; y < boardSizeY; y++)
            {
                blocks[x, y] = transform.GetChild(x * boardSizeY).gameObject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
