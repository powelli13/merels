using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GameBoardNode : MonoBehaviour
{
    [SerializeField]
    GameObject testTriangle;

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
        

        if (!isRed) {
            GetComponent<SpriteRenderer>().color = Color.red;
            isRed = true;
            testTriangle.SetActive(true);
        } else {
            GetComponent<SpriteRenderer>().color = Color.gray;
            isRed = false;
            testTriangle.SetActive(false);
        }
    }
}
