using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class Exercicio07 : MonoBehaviour
{
    //    (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    // calcular probabilidades e simular a rolagem de dados.Crie um
    //script em que o usuário defina o número de faces de um dado
    //    (int) e calcule a rolagem de um dado com esse número de faces.
    //Use a função abaixo para o cálculo: Random.Range (valor_min,
    //valor_max); (Coloque o código dentro da função-evento Start).

    [SerializeField] int faces;

    void Start()
    {

        //if (faces == 0)
        //{
        //    print("O numero de fases do dado não pode ser: " + faces);
        //}
        //else
        //{
        //    print (Random.Range(1, faces));
        //}

        print(faces == 0 ? ("O numero de fases do dado não pode ser: " + faces) : (Random.Range(1, faces)));
        
    }

    
    void Update()
    {
        
    }
}
