using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State, nxtState1, nxtState2;
    public ChangeTxT[] texts;
    public Sprite[] sprites;
    public ChangeImg[] images;
    public StatusEffectStorage efctStorage;
    public GameObject twoButtons, oneButton;

    private void Awake()
    {
        Instance = this;
    }

    //Liste aller GameStates
    public enum GameState
    {
        StartScreen0,
        Early1,
        Late2,
        GameEnd3
    }


    private void Start()
    {
        //Setzt die Start Szene
        UpdateGameState(0);
        //Findet den StatusEffectStorage
        efctStorage = GameObject.FindGameObjectWithTag("statusEfctStorage").GetComponent<StatusEffectStorage>();


    }

    //Updatet den GameState zum in der Variable spezifizierten
    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.StartScreen0:
                Invoke("STStart0", 0.01f);
                break;
            case GameState.Early1:
                STEarly1();
                break;
            case GameState.Late2:
                STLate2();
                break;
            case GameState.GameEnd3:
                EndGame();
                break;
        }
    }

    //Check wann und welcher Knopf gedrückt wurde
    public void BtnPressed(int btnNumber)
    {
        if (btnNumber == 0)
        {
            UpdateGameState(nxtState1);
        }

        if (btnNumber == 1)
        {
            UpdateGameState(nxtState2);
        }

        
    }


    //ST == Scene Transition, setzt Text, Bild, Ambience & co für neue Szenen
    public void STStart0()
    {
        //no status effects

        texts[0].SetText("First Scene");
        texts[1].SetText("In Bed");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("early");
        texts[5].SetText("late");

        images[0].SetImg(sprites[0]);

        nxtState1 = GameState.Early1;
        nxtState2 = GameState.Late2;
    }

    public void STEarly1()
    {
        efctStorage.statusEffects[0] = true;

        texts[0].SetText("Second Scene");
        texts[1].SetText("Home");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("quick");
        texts[5].SetText("slow");

        images[0].SetImg(sprites[1]);

        nxtState1 = GameState.GameEnd3;
        nxtState2 = GameState.GameEnd3;
    }

    public void STLate2()
    {
        efctStorage.statusEffects[2] = true;

        texts[0].SetText("Third Scene");
        texts[1].SetText("Home");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("quick");
        texts[5].SetText("slow");

        images[0].SetImg(sprites[1]);

        nxtState1 = GameState.GameEnd3;
        nxtState2 = GameState.GameEnd3;
    }



    public void EndGame()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Game is over");
        images[0].SetImg(sprites[2]);
    }
}
