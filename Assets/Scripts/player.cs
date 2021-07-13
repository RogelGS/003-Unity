using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float vel_x;
    public float vel_incrementar;
    public gameHandler gameHandler;
    bool vivo = true;

    public GameObject min;
    public GameObject max;
    // Start is called before the first frame update
    void Start()
    {
        gameHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameHandler>();
        min = GameObject.Find("min");
        max = GameObject.Find("max");
    }

    // Update is called once per frame
    void Update()
    {
        if (vivo)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 1.0f);
                GetComponent<Animator>().SetBool("fly", true);
                gameHandler.reproducir_sfx(4);
            }
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(vel_x, GetComponent<Rigidbody2D>().velocity.y);
    }

    void LateUpdate()
    {
        check_limits();
    }

    void restaurarIdle() 
    { 
        GetComponent<Animator>().SetBool("fly", false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(vivo)
        {
            muerte();
        }
    }

    void check_limits()
    {
        if(vivo)
        {
            if (transform.position.y > max.transform.position.y)
            {
                muerte();
            }
            else if (transform.position.y < min.transform.position.y)
            {
                muerte();
            }
        }
    }

    public void muerte()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        gameHandler.reproducir_sfx(1);
        vel_x = 0.0f;
        vivo = false;
        gameHandler.perder();
        GetComponent<Rigidbody2D>().freezeRotation = false;
    }
}
