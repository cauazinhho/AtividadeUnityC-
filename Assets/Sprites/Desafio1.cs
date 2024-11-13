using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    [SerializeField] string texto = "Jogos digitais";
    [SerializeField] int contadorConsoantes;
    void Start()
    {
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if("bcdfghjklmnpqrstvwxyz".Contains(letra))
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
