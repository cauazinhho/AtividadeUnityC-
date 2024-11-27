using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    //Fa�a um algoritmo que receba o dia, o m�s e o ano em que uma pessoa nasceu
    //imprima na tela quantos anos, meses e dias essa pessoa j� viveu.
    //Leve em considera��o o ano com 365 dias e o m�s com 30 dias.

    [SerializeField] int diaNascimento;
    [SerializeField] int mesNascimento;
    [SerializeField] int anoNascimento;
    void Start()
    {
        //Data Atual
        int diaAtual = DateTime.Now.Day;
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        //Calcular anos vividos
        int anosVividos = anoAtual - anoNascimento;

        //Calcular meses vividos
        int mesesVividos = mesAtual - mesNascimento;

        // Se o valor for negativo do mes, ele vai entra nessa condi��o, ent o valor negativo vai receber +12
        if (mesesVividos < 0)
        {
            anosVividos--;
            mesesVividos += 12;
        }

        //Calcular dias vividos
        int diasVividos = diaAtual - diaNascimento;

        if (diasVividos < 0)
        {
            mesesVividos--;
            diasVividos += 30;

            if (mesesVividos < 0)
            {
                anosVividos--;

                //mesesVividos = mesesVividos + 12; ---- so para n�o deixar os meses negativos -- pq n existe mes zero
                mesesVividos += 12;
            }
        }

        print("Voc� viveu: " + diasVividos + "dias, " + mesesVividos + "meses, " + anosVividos + " anos");

        // --------------------------------------------------------------------------------------------------------------------------------------

        //Total de dias vividos
        //int totalDiasVividos = (anoAtual - anoNascimento) * 365 + (mesAtual - mesNascimento) * 30 + (diaAtual - diaNascimento);

        ////Converte para anos, meses e dias restantes
        //int anosVividos = totalDiasVividos / 365;
        //int mesesVividos = (totalDiasVividos % 365) / 30;
        //int diasVividos = (totalDiasVividos % 365) % 30;

        //print("Voc� viveu: " + diasVividos + "dias, " + mesesVividos + "meses, " + anosVividos + " anos");

    }

    
    void Update()
    {
        
    }
}
