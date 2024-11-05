using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio10 : MonoBehaviour
{
    //(Itens do inventário) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens(como moedas, poções, ou power-ups)
    //que têm efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.

    [SerializeField] int coletavel;

    void Start()
    {
        switch (coletavel)
        {
            case 1:
                print("Player coletou uma moeda! ");
                break;

            case 2:
                print("Player coletou poções!! ");
                break;

            case 3:
                print("Player coletou um Power-Up!!! ");
                break;
                
            default:
                print("Nenhum efeito encontrado ");
                break;
        }
    }

     
    void Update()
    {
        
    }
}
