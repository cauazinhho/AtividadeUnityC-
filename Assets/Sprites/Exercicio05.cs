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

    [SerializeField] int pontuacao = 50;

    void Start()
    {
        if (pontuacao < 50)
        {
            print("Miss�o Incompleta");
        }
        else 
        {
            print("Miss�o bem-sucedida");
        }
    }

    
    void Update()
    {
        
    }
}
