using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    [SerializeField] bool powerUp;


    void Start()
    {
        if (powerUp == true)
        {
            print("Power-Up Coletado!");
        }
        else
            {
                print("Nenhum power-up encontrado");
            }

        print((powerUp == true) ? "Power-Up Coletado" : "Nenhum power-up encontrado");

    }
        void Update()
        {

        }
}
