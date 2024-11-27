using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    //Escreva um programa que conta o n�mero de consoantes em uma string.

    [SerializeField] string texto = "Jogos digitais";
    [SerializeField] int contadorConsoantes;
    void Start()
    {
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(letra) || "bcdfghjklmnpqrstvwxyz".ToUpper().Contains(letra))
            {
                contadorConsoantes++;
            }

            // (*Vers�o Errada*)
            //if (!"aeiou".Contains(char.ToLower(letra)))
            //{
            //    contadorConsoantes++;
            //}
        }

        print("O numero de consoantes �: " + contadorConsoantes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
