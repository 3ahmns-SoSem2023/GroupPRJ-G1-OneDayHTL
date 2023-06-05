using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;
    public ChangeTxT[] texts;
    public Sprite[] sprites;
    public ChangeImg[] images;

    private void Awake()
    {
        Instance = this;
    }

    public enum GameState
    {
        StartScreen0,
        Early1,
        Late2
    }

    private void Start()
    {
        UpdateGameState(0);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.StartScreen0:
                STStart0();
                break;
            case GameState.Early1:
                STEarly1();
                break;
            case GameState.Late2:
                STLate2();
                break;
        }
    }

    public void BtnPressed(int btnNumber)
    {
        if (btnNumber == 0)
        {
            UpdateGameState(State + 1);
        }

        if (btnNumber == 1)
        {
            UpdateGameState(State + 2);
        }

        
    }

    public void STStart0()
    {
        texts[0].SetText("First Scene");
        texts[1].SetText("In Bed");
        texts[2].SetText("/");
        texts[3].SetText("Choose");
        texts[4].SetText("early");
        texts[5].SetText("late");
    }

    public void STEarly1()
    {
        texts[0].SetText("Second Scene");
        texts[1].SetText("Home");
        texts[2].SetText("tired");
        texts[3].SetText("Choose");
        texts[4].SetText("quick");
        texts[5].SetText("slow");
        images[0].SetImg(sprites[0]);
    }

    public void STLate2()
    {
        texts[0].SetText("Third Scene");
        texts[1].SetText("Home");
        texts[2].SetText("/");
        texts[3].SetText("Choose");
        texts[4].SetText("quick");
        texts[5].SetText("slow");
    }
}
