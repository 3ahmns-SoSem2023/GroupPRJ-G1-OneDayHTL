using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;

    private void Awake()
    {
        Instance = this;
    }
    public int gameState;

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.FirstScreen:
                break;
            case GameState.SecondScreen:
                break;
            case GameState.ThirdScreen:
            default:
                break;
        }
    }

    public void BtnPressed(int btnNumber)
    {
        if (btnNumber == 0)
        {

        }

        if (btnNumber == 1)
        {

        }
    }

    public enum GameState
    {
        FirstScreen,
        SecondScreen,
        ThirdScreen
    }
}
