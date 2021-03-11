using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Atribui a força diretamente
    //Coloquei a bola grudada na camera como se o jogador tivesse a segurando
    public GameObject bola;
    public GameObject CameraJogador;

    public float forçaBola = 5f;
    public float distanciaBola = 2f;

    public bool segurarBola = true;
    
    void Start()
    {
        bola.GetComponent<Rigidbody> ().useGravity = false;
        
    }

    
    void Update()
    {
        if (segurarBola)
        {
            bola.transform.position = CameraJogador.transform.position + CameraJogador.transform.forward * distanciaBola;

            if (Input.GetMouseButtonDown(0))
            {
                segurarBola = false;
                bola.GetComponent<Rigidbody>().useGravity = true;
                bola.GetComponent<Rigidbody>().AddForce(CameraJogador.transform.forward *forçaBola) ;
                TentativasScript.chancesValue += 1;
            }
        }
    }
}
