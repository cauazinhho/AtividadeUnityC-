using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Exer07 : MonoBehaviour
{
    //7. (Maior n�mero em uma lista) Dada uma lista de n�meros encontre o maior valor.

    int maior = 0;
    int[] numeros = { 3, 5, 45, 7, 10, 68, 23, 71, 18, 97 };
        
    void Start()
    {
        maior = numeros[0];

        foreach (var item in numeros)
        {
            if (item > maior)
            {
                maior = item;
            }
        }

        print("O maior numero �: " + maior);
    }

   
    void Update()
    {
        
    }
}
