using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubos_conjunto : MonoBehaviour
{
    gameHandler gameHandler;
    // Start is called before the first frame update
    void Start()
    {
        gameHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            gameHandler.agregar_punto();
        }
    }
}
