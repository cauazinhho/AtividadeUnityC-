using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    
    [SerializeField] public int vidaPlayer = 100;
    //string resultado;
    void Start()
    {
        if (vidaPlayer > 0)
        {
            print("Personagem Vivo!");
        }
        else 
        {
            print("Game Over");
        }

        // Ternario
        // Condíção ? valor a ser chamado caso verdadeiro : falso
        //resultado = (vidaPlayer > 0) ? "Personagem Vivo!" : "Game Over";
        //print(resultado);
    }

    
    void Update()
    {
        
    }
}
