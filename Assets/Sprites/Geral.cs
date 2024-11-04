using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{

    //!= diferente

    //public string variavelPublica;

    //private string variavelPrivada;

    //[SerializeField]private int vidaJogador = 10;

    //float velocidadecarro = 125.5f;

    //string nomejogador = "tadala";

    //char apelido = 't';

    // verdadeiro ou falso
    //bool vivo = true;

    public int vida_Jogador;


    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;

    void Start()
    {
        //Debug.Log(vidaJogador);
        //print(vidaJogador);



        print(vidaVilao == vidaHeroi); //false
        print(vidaHeroi <= vidaVilao); //true
        print(vidaVilao != vidaHeroi); //true
        int resultado;

        //Operador Ternário
        // Condição ? valor a ser atribuido caso seja verdadeiro : caso seja falso
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Vilao Maior";

        //print(resultado);

        //if (vidaHeroi < vidaVilao)
        //{
        //    resultado = "Vida Heroi Menor";
        //    print(resultado);
        //}
        //else if (vidaHeroi == vidaVilao)
        //{
        //    resultado = "Vida Heroi igual a vida Vilao";
        //    print(resultado);
        //}
        //else
        //{
        //}

        void Update()
        {


        }
    }
}
