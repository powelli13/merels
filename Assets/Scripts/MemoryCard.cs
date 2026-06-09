using System;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField]
    GameObject cardBack;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (cardBack.activeSelf)
        {
            cardBack.SetActive(false);
        }
    }
}
