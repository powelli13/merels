using UnityEngine;

public class CrossPiece : MonoBehaviour
{
    [SerializeField]
    Sprite image;
    // TODO will this give us collision for movement clicks?
    // the pieces will be larger than the nodes so we'll need collission

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       GetComponent<SpriteRenderer>().sprite = image; 

        float posX = 0f;
        float posY = 0f;
        float posZ = 0f;

       this.transform.position = new Vector3(posX, posY, posZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlacePiece()
    {
        // TODO take in a location and display the piece there
    }
}
