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
//variável inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcançar o valor 24. Quando
//completar um ciclo, incremente uma variável dias e escreva o
//número de dias que se passaram no console. (Coloque o código
//dentro da função-evento Update).

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
