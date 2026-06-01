using UnityEngine;
using UnityEngine.UIElements;

public class GameBoardNode : MonoBehaviour
{
    private bool isRed = false;


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
        Debug.Log("Sprite clicked: " + gameObject.name);
        

        if (!this.isRed) {
            GetComponent<SpriteRenderer>().color = Color.red;
            this.isRed = true;
        } else {
            GetComponent<SpriteRenderer>().color = Color.gray;
            this.isRed = false;
        }
    }
}
