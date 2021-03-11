using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TentativasScript : MonoBehaviour
{
    //Mostrar tentativas
    public static int chancesValue = 0;
    Text chances;

    void Start()
    {
        chances = GetComponent<Text>();
    }

    
    void Update()
    {
        chances.text = "Chances:" + chancesValue;
    }
}
