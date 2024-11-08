using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    // For -> É utilizado quando se sabe a qtd. de repetiçoes

    // While ou DoWhile -> É utilizado quando nao se sabe a qtd de repetições

    // ForEach -> Usado em listas ou arrays para executar uma operações para cada item da lista 

    // Array -> É uma lista 

    int x = 0; //While
    int y = 10; //DoWhile

    // Criando uma lista de numeros inteiros chamada 'nums'
    List<int> nums = new List<int>();

    void Start()
    {
        //for (int i = 0; i <= 10; i++)
        //{
        //    if (i == 5)
        //        break;
        //}

        //if (i == 6)
        //{
        //    continue;
        //}

        //print(i);

        //while
        //while (x < 10)
        //{
        //    print(x);
        //    x++;
        //}

        ////Do While
        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        //print(num[3]);
        //num[0]++;

        //print(num[0]);

        //string[] nomes;

        //nomes = new string[5];
        //nomes[0] = "Tadola";

        //print(nomes[1]);

        //for (int i = 0; i < 8; i++)
        //{
        //    print(num[i]);
        //}

        //foreach (var item in num)
        //{
        //    print(item+1);
        //}

        //--------------------------------------------------


        // Adiciona elementos á lista de nums
        nums.Add(1); // Indice 1
        nums.Add(2);
        nums.Add(3);
        nums.Add(4);
        nums.Add(5);
        nums.Add(6);
        nums.Add(7);
        nums.Add(8); // Indice 7

        // Remove o primeiro valor '4' encontrado na lista do (indice 3)
        nums.Remove(4);

        // Ordena os elementos da lista de ordem crescente
        nums.Sort();

        nums.Reverse();

        nums.IndexOf(1);

    }

     void Update()
    {
        
    }
}
