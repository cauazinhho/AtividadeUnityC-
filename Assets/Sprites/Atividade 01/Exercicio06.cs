using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    //(Escolha de personagem) O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.

    [SerializeField] bool Guerreiro;
    [SerializeField] bool Mago;
    //[SerializeField] int Personagem;

    void Start()
    {

        if (Mago == true && Guerreiro == false)
        {
            print("Mago escolhido");

        }
        else if (Mago == false && Guerreiro == true)
        {
            print("Guerreiro escolhido");
        }
        else if (Mago && Guerreiro)
        {
            print("Escolha apenas um");
        }
        else
        {
            print("Não será possivel jogar");
        }

        //switch(Personagem)
        //{
        //    case 1:
        //        print("Guerreiro Escolhido");
        //    break;

        //    case 2:
        //        print("Mago Escolhido");
        //    break;

        //        default:
        //        print("Classe do personagem não encontrada");
        //        break;
        //}
    }


        void Update()
        {

        }

} 

