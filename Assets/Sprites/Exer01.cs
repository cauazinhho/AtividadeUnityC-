using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer01 : MonoBehaviour
{
    // 1. (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "In�cio da partida!" ao final.
    
        void Start()
        {

        // for (primeira parte, inicializador; condi��o; incremento)
        for (int contagem = 5; contagem > 0; contagem--)
        {
            print(contagem);
        }
        print("In�cio da partida!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
