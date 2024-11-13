using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer02 : MonoBehaviour
{
    
    //2. (Multiplicação de dano) Um personagem ataca cinco vezes,
    //e o dano do ataque aumenta em 2 a cada vez.Exiba o dano a
    //cada ataque.

    [SerializeField] int dano = 10;
    void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            print("Ataque " + i + ": Dano " + dano);
            //dano = dano + 2
            dano += 2;
        }
    }

    
    void Update()
    {
        
    }
}
