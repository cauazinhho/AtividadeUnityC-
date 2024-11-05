using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    //(Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    [SerializeField] bool pocaoVida;
    string resultado;
    void Start()
    {
        print(resultado = pocaoVida ? "Usando Poção de Vida" : "Poção indisponível");


        //if (pocaoVida) //Nao precisa colocar o == true, pq ja vem como padrão
        //{
        //    print("Usando Poção de Vida");
        //}
        //else 
        //{
        //    print("Poção Indisponível");
        //}


    }

    
    void Update()
    {
        
    }
}
