using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer04 : MonoBehaviour
{
    //    4. (Pontua��o em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontua��o total ap�s 7 combos.

    [SerializeField] int pontuacao = 0;
    
    void Start()
    {
        for (int combo = 1; combo <= 7; combo++)
        {
            pontuacao += 10;
        }

        print("Pontua��o total: " + pontuacao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
