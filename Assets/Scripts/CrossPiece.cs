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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        Debug.Log("you clicked on a cross piece :)");
    }

    public void PlacePiece(Vector3 pos)
    {
       this.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
