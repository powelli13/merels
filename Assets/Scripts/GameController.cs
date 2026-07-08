using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    /**
    TODO board shape diagram with IDs
    */
    // We give this a length in the GUI, so we can rely on the board shape above
    // The preset structure of the board allows for quickly checking for 3 in a row scores
    //[SerializeField]
    //BoardNode[] boardNodes;

    [SerializeField]
    BoardNode originalNode;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupBoard();        
    }

    // Set up the board programmatically to static offsets from the center of the screen
    // rather than manually in the GUI.
    void SetupBoard()
    {
        // offsets
        // first circle: x:2 y:1
        // second circle: x:3.25 y:2.25
        // third circle: x:4.5 y:3.5

        // The board center
        Vector3 bc = transform.position;

        // I use a static board node positions so that the Node IDs can be found reliably
        // in the different positions.
        // This may be overkill but I'll simplify later. For now I like having the board
        // setup in code rather than the GUI.
        Dictionary<int, (float x, float y)> nodeOffsets = new()
        {
           // Upper top row
           [0] = (x: bc.x - 4.5f, y: bc.y + 3.5f), 
           [1] = (x: bc.x, y: bc.y + 3.5f),
           [2] = (x: bc.x + 4.5f, y: bc.y + 3.5f),
           // Upper middle Row
           [3] = (x: bc.x - 3.25f, y: bc.y + 2.25f),
           [4] = (x: bc.x, y: bc.y + 2.25f),
           [5] = (x: bc.x + 3.25f, y: bc.y + 2.25f),
           // Upper bottom row
           [6] = (x: bc.x - 2, y: bc.y + 1),
           [7] = (x: bc.x, y: bc.y + 1),
           [8] = (x: bc.x + 2, y: bc.y + 1),
           // Center row, left side
           [9] = (x: bc.x - 4.5f, y: bc.y),
           [10] = (x: bc.x - 3.25f, y: bc.y),
           [11] = (x: bc.x - 2, y: bc.y),
           // Center row, left side
           [12] = (x: bc.x + 2, y: bc.y),
           [13] = (x: bc.x + 3.25f, y: bc.y),
           [14] = (x: bc.x + 4.5f, y: bc.y),
           // Lower top row 
           [15] = (x: bc.x - 2, y: bc.y - 1),
           [16] = (x: bc.x, y: bc.y - 1),
           [17] = (x: bc.x + 2, y: bc.y - 1),
           // Lower middle row 
           [18] = (x: bc.x - 3.25f, y: bc.y - 2.25f),
           [19] = (x: bc.x, y: bc.y - 2.25f),
           [20] = (x: bc.x + 3.25f, y: bc.y - 2.25f),
           // Lower bottom row
           [21] = (x: bc.x - 4.5f, y: bc.y - 3.5f),
           [22] = (x: bc.x, y: bc.y - 3.5f),
           [23] = (x: bc.x + 4.5f, y: bc.y - 3.5f) 
        };

        BoardNode node;
        for (int id = 0; id < 24; id++)
        {
            // Set original Node
            if (id == 0)
            {
                node = originalNode;
            }
            else
            {
                node = Instantiate(originalNode) as BoardNode;
            }

            node.SetBoardNode(id);

            float posX = nodeOffsets[id].x;
            float posY = nodeOffsets[id].y;

            node.transform.position = new Vector3(posX, posY, bc.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Just for learning
    public void ReportClick(int clickedId)
    {
        Debug.Log("From GameControler: BoardNode clicked ID: " + clickedId);
    }
}
