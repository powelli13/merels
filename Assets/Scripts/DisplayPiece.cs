using UnityEngine;

public class DisplayPiece : MonoBehaviour
{
    // TODO add gamecontroller and collisions for images
    [SerializeField]
    Sprite crossImage;

    [SerializeField]
    Sprite circleImage;

    [SerializeField]
    GameController gameController;

    // TODO where should these live?
    public static int CROSS_PIECE = 1;

    public static int CIRCLE_PIECE = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        Debug.Log("you clicked on a cross piece :)");
    }

    // TODO I'd like to share the piece type as readable constants for better readability
    public void PlacePiece(Vector3 pos, int pieceType)
    {
        Debug.Log("Placing a display piece");
        GetComponent<SpriteRenderer>().sprite = pieceType == DisplayPiece.CROSS_PIECE
            ? crossImage
            : circleImage; 
        Debug.Log("repositioning a display piece");
        this.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
