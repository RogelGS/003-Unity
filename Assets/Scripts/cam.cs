using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{

    float pos_y_init;
    // Start is called before the first frame update
    void Start()
    {
        pos_y_init = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, pos_y_init, transform.position.z);
    }
}
