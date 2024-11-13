using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //(Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC(personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    [SerializeField] int npc;

    void Start()
    {
        switch (npc)
        {
            case 1:
                print("");
                break;
            
            case 2:
                print("");
                break;

            case 3:
                print("");
                break;

        }

        
    }

     
    void Update()
    {
        
    }
}
