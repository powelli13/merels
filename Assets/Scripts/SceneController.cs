using System.Data.Common;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    MemoryCard originalCard;

    [SerializeField]
    Sprite[] images;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int id = Random.Range(0, images.Length);
        originalCard.SetCard(id, images[id]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
