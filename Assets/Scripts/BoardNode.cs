using UnityEngine;

public class BoardNode : MonoBehaviour
{
    [SerializeField]
    GameController gameController;

    private int _id;
    private bool _selected;

    public int Id
    {
        get { return _id; }
    }

    public bool Selected
    {
        get { return _selected; }
        set { _selected = value; }
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
        Debug.Log("Node is now selected");
        gameController.ReportClick(_id);

        // TODO just messing around with basic plumbing for states
        // TODO design question: should this selection management be owned by the node or the game controller?
        // I think it makes more sense to have the board node own it and the game controller check it
        if (!_selected)
        {
            _selected = true;
        }
    }

    public void SetBoardNode(int id)
    {
        _id = id;
    }
}
