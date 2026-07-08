using UnityEngine;

public class BoardNode : MonoBehaviour
{
    [SerializeField]
    GameController gameController;

    // [SerializeField]
    // int _id;

    private int _id;

    public int Id
    {
        get { return _id; }
    }

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
        Debug.Log("Node clicked with ID: " + _id);
        gameController.ReportClick(_id);
    }

    public void SetBoardNode(int id)
    {
        _id = id;
    }
}
