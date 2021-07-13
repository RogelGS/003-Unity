using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float velDesp;
    Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 desplazamiento = new Vector2(Mathf.Repeat(Time.time * velDesp, 1), 0.0f);
        render.sharedMaterial.SetTextureOffset("_MainTex", desplazamiento);
    }
}
