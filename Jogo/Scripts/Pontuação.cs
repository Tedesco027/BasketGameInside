using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuação : MonoBehaviour
{
    //Sistema de Pontuação
    public GameObject efeitoPonto;
        void Start()
    {
        efeitoPonto.SetActive(false);
    }

    void OnTriggerEnter (Collider Colisao)
    {
        if (Colisao.GetComponent<Bola> () != null)
        {
            efeitoPonto.SetActive(true);
            ScoreScript.scoreValue += 1;
        }
    }
}
