using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor.PackageManager;
using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio08 : MonoBehaviour
{
//    (Contador de horas e dias) Crie um script que em que uma
//vari�vel inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
//completar um ciclo, incremente uma vari�vel dias e escreva o
//n�mero de dias que se passaram no console. (Coloque o c�digo
//dentro da fun��o-evento Update).

    [SerializeField] int hora;
    [SerializeField] int dia;
    [SerializeField] float segundos;

    void Start()
    {
    }

     
    void Update()
    {
        segundos += Time.deltaTime;
        
    }
}
