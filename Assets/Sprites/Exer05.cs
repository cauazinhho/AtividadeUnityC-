using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer05 : MonoBehaviour
{
    //    5. (Aumento de n�vel de dificuldade) A cada fase completada, a
    //dificuldade aumenta em 5 pontos.Exiba a dificuldade ap�s cada
    //fase, em um total de 6 fases.

    [SerializeField] int dificuldade = 0;
    void Start()
    {
        for (int fase = 1; fase <= 6; fase++)
        {
            dificuldade += 5;
            print("Fase " + fase + ": Dificuldade " + dificuldade);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
