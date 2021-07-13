using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour
{
    public GameObject puntos_obj;
    public player player;
    public GameObject sfx;
    public GameObject gameOver;
    public GameObject back_script;

    public float vel_max;

    int puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void agregar_punto()
    {
        puntos += 1;
        reproducir_sfx(2);
        if(puntos%10 == 0 && player.vel_x < vel_max)
        {
            player.vel_x += player.vel_incrementar;
        }
        actualizar_puntos();
    }

    public void resetear_partida()
    {
        puntos = 0;
    }

    public void actualizar_puntos()
    {
        puntos_obj.GetComponent<Text>().text = puntos.ToString();
    }

    public void reproducir_sfx(int num)
    {
        sfx.GetComponent<sfx>().play(num);
    }

    public void perder()
    {
        back_script.GetComponent<Background>().enabled = false;
        gameOver.SetActive(true);
    }
}
