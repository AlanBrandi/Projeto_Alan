using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnumGameStates
{
    Jogando,
    Pause,
    GameOver,
}

public class estado : MonoBehaviour
{
    public EnumGameStates states = EnumGameStates.Jogando;
    public string situacao = "Parado";

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            situacao = "Jogando";
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            situacao = "Pause";
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            situacao = "GameOver";
        }


        switch (situacao)
        {
            case "Jogando":
                print("Jogando");
                break;
            case "Pause":
                print("Pausado");
                break;
            case "Game Over":
                print("GameOver");
                break;
        }
    }
}
