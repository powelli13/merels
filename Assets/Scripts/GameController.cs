using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    /**
    TODO board shape diagram with IDs
    */
    // We give this a length in the GUI, so we can rely on the board shape above
    // The preset structure of the board allows for quickly checking for 3 in a row scores
    [SerializeField]
    BoardNode[] boardNodes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
