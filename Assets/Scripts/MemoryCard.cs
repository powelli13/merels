using System;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField]
    GameObject cardBack;

    [SerializeField]
    Sprite image;

    [SerializeField]
    SceneController controller;

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

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    void OnMouseDown()
    {
        if (cardBack.activeSelf)
        {
            cardBack.SetActive(false);
        }
    }
}
