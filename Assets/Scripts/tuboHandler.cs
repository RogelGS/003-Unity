using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuboHandler : MonoBehaviour
{

    public float offset_x;

    public  List<GameObject> tubos;

    float min = -0.556f;
    float max = 0.205f;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Tubo"))
        {
            tubos = new List<GameObject>(GameObject.FindGameObjectsWithTag("Tubo"));
            for(int i = 0; i < tubos.Count; i++)
            {
                tubos[i].transform.position = new Vector2(tubos[i].transform.position.x, Random.Range(min, max));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pushTubo()
    {
        tubos[0].transform.position = new Vector2(tubos[tubos.Count-1].transform.position.x + offset_x, Random.Range(min, max));

        GameObject provis = tubos[0];
        tubos.RemoveAt(0);
        tubos.Insert(tubos.Count, provis);


    }

}
