using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer03 : MonoBehaviour
{
    //3. (C�lculo de moedas coletadas) O jogador coleta 3 moedas a
    //cada fase.Ap�s 10 fases, exiba o total de moedas coletadas.

        [SerializeField] int totalMoeda = 0;

        void Start()
        {
        for (int fase = 1; fase <= 10; fase++)
        {
            //totalMoeda = totalMoeda + 3;
            totalMoeda += 3;

        }
        
        print("Total de moedas: " + totalMoeda);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
