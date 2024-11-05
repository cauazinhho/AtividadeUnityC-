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

    [SerializeField] int pontuacao = 0;

    void Start()
    {
        if (pontuacao >= 50)
        {
            print("Missão bem-sucedida");
        }
        else 
        {
            print("Missão incompleta");
        }

        // condicao ? caso vdd : caso falso
        // print(pontos>= ? "Missão bem-sucedida" : "Missão incompleta");

    }


    void Update()
    {
        
    }
}
