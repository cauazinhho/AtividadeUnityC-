using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio05 : MonoBehaviour
{
    //(Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    //incompleta".

    [SerializeField] int pontuacao = 0;

    void Start()
    {
        if (pontuacao >= 50)
        {
            print("Miss�o bem-sucedida");
        }
        else 
        {
            print("Miss�o incompleta");
        }

        // condicao ? caso vdd : caso falso
        // print(pontos>= ? "Miss�o bem-sucedida" : "Miss�o incompleta");

    }


    void Update()
    {
        
    }
}
