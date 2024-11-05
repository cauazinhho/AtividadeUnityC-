using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    //(Escolha de personagem) O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.

    //[SerializeField] int Guerreiro;
    //[SerializeField] int Mago;
    [SerializeField] int Personagem;

    void Start()
    {
        switch(Personagem)
        {
            case 1:
                print("Guerreiro Escolhido");
            break;

            case 2:
                print("Mago Escolhido");
            break;

                default:
                print("Classe do personagem não encontrada");
                break;
        }



    }


        void Update()
        {

        }

} 

