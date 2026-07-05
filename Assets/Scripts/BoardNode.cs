using UnityEngine;

public class BoardNode : MonoBehaviour
{
    [SerializeField]
    GameController gameController;

    [SerializeField]
    int id;

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
        Debug.Log("Node clicked with ID: " + id);
        gameController.ReportClick(id);
    }
}
