using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio05 : MonoBehaviour
{
    //(Pontuação de missão) Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".

    [SerializeField] int pontuacao = 50;

    void Start()
    {
        if (pontuacao < 50)
        {
            print("Missão Incompleta");
        }
        else 
        {
            print("Missão bem-sucedida");
        }
    }

    
    void Update()
    {
        
    }
}
