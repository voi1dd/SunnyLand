using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletaveis : MonoBehaviour
{
    private int pontos = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo come�ou"  + pontos + "pontos.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Rodando");     
    }
}
