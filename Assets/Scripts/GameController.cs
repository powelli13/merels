using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    /**
    TODO board shape diagram with IDs
    */
    [SerializeField]
    BoardNode originalNode;

    // Map of node IDs to the triplet groups in which they can score.
    // This is essentially a pre-calculation of all the scoring triplets.
    // It is helpful because of the structure of the board not being an orthoganal grid.
    // TODO add more, also mess around with different types, maybe tuples are faster
    private Dictionary<int, List<int[]>> _scoringTriplets = new()
    {
        [0] = new List<int[]> {new int[] {0, 1, 2}, new int[] {0, 4, 7}},
        [1] = new List<int[]> {new int[] {0, 1, 2}, new int[] {1, 5, 8}},
        [2] = new List<int[]> {new int[] {0, 1, 2}, new int[] {2, 6, 9}}
    };

    private Dictionary<int, BoardNode> _nodes = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupBoard();
    }

    // Set up the board programmatically to static offsets from the center of the screen
    // rather than manually in the GUI.
    void SetupBoard()
    {
        // The board center
        Vector3 bc = transform.position;

        // offsets
        // first circle: x:2 y:1
        // second circle: x:3.25 y:2.25
        // third circle: x:4.5 y:3.5
        // I use a static board node positions so that the Node IDs can be found reliably
        // in the different positions.
        // This may be overkill but I'll simplify later. For now I like having the board
        // setup in code rather than the GUI.
        // Could possibly setup two loops instead that loop through the offsets for x and y
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

            // TODO is this the cleanest approach?
            _nodes.Add(id, node);

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

        // TODO trying out different wiring structures for three in a row scoring detections
        // Check if the movement selected three in a row
        // TODO this might throw an error on a board reference value, that would mean some setup is broken
        DetectScore(clickedId);
    }

    // TODO add piece type in the future
    private bool DetectScore(int nodeId)
    {
        // get potential scores based on the nodeId
        // determine if all are active or the same player piece
        // return true on first find
        // return a bool because we can only score once per turn
        var possibleMatches = _scoringTriplets[nodeId];

        // I like this structure, maybe try tuples as well though
        // Should also add guards to avoid nodeIds causing exceptions
        // Maybe just a little helper function to return only if the node ID exists
        foreach (var triplet in possibleMatches)
        {
            Debug.Log("The triplet is: " + triplet.ToString());
            foreach (var subId in triplet)
            {
                Debug.Log("Sub ID is: " + subId);
            }
            //jif ()
            //j{

            //j}
        }

        return false;
    }
}
