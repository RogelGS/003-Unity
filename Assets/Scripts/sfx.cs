using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{

    public List<AudioClip> efectos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public  void play(int num)
    {
        GetComponent<AudioSource>().clip = efectos[num];
        GetComponent<AudioSource>().Play();
    }
}
