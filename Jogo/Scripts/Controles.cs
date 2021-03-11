using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controles : MonoBehaviour
{
    //Resetar a cena 3 segundos depois do jogador lançar a bola
    public Player player;
    public float resetLance = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        if (player.segurarBola == false)
        {
            resetLance -= Time.deltaTime;
            if (resetLance <= 0)
            {
                SceneManager.LoadScene("pisobasket");
            }
        }
    }
}
