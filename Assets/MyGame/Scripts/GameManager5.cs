using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager5 : MonoBehaviour
{
    public static GameManager5 Instance;
    public GameState State, nxtState1, nxtState2;
    public ChangeTxT[] texts;
    public Sprite[] sprites;
    public ChangeImg[] images;
    public StatusEffectStorage efctStorage;
    public GameObject twoButtons, oneButton, storageObj;

    [Header("Wwise Variablen")]
    public GameManager forWwise; 

    private void Awake()
    {
        Instance = this;
    }

    //Liste aller GameStates
    public enum GameState
    {
        StartScreen0,
        Skip1,
        Stay2,
        Dodge3,
        Ignore4,
        Ending8,
        Ending9,
        Ending10
    }


    private void Start()
    {
        //Findet den StatusEffectStorage
        storageObj = GameObject.Find("StatusEffectStorage");
        efctStorage = storageObj.GetComponent<StatusEffectStorage>();
        //Setzt die Start Szene
        UpdateGameState(0);
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
            case GameState.Skip1:
                STSkip1();
                break;
            case GameState.Stay2:
                STStay2();
                break;
            case GameState.Dodge3:
                STDodge3();
                break;
            case GameState.Ignore4:
                STIgnore4();
                break;
            case GameState.Ending8:
                Ending8();
                break;
            case GameState.Ending9:
                Ending9();
                break;
            case GameState.Ending10:
                Ending10();
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

    public void OneButton()
    {
        twoButtons.SetActive(false);
        oneButton.SetActive(true);
    }

    public void TwoButton()
    {
        twoButtons.SetActive(true);
        oneButton.SetActive(false);
    }


    //All scene transitions
    //ST == Scene Transition, setzt Text, Bild, Ambience & co für neue Szenen
    public void STStart0()
    {
        //no status effects

        texts[0].SetText("First Scene");
        texts[1].SetText("In School");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("Skip");
        texts[5].SetText("Stay");

        images[0].SetImg(sprites[0]);

        nxtState1 = GameState.Skip1;
        nxtState2 = GameState.Stay2;

        //Wwise
        
    }

    public void STSkip1()
    {
        texts[0].SetText("Second Scene");
        texts[1].SetText("In School");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("Dodge");
        texts[5].SetText("Ignore");

        images[0].SetImg(sprites[1]);

        nxtState1 = GameState.Dodge3;
        nxtState2 = GameState.Ignore4;
        //Wwise
        
    }
    //Update this
    public void STStay2()
    {
        UpdateGameState(GameState.Ending8);
        //Wwise
        
    }

    public void STDodge3()
    {
        UpdateGameState(GameState.Ending9);
        //Wwise
        
    }

    public void STIgnore4()
    {
        UpdateGameState(GameState.Ending10);
        //Wwise
        
    }

    public void Ending8()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending8");
        images[0].SetImg(sprites[2]);


        //Wwise
        forWwise.playStartAndEndingMusic.Post(gameObject);
    }

    public void Ending9()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending9");
        images[0].SetImg(sprites[2]);


        //Wwise
        forWwise.playStartAndEndingMusic.Post(gameObject);
    }

    public void Ending10()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending10");
        images[0].SetImg(sprites[2]);


        //Wwise
        forWwise.playStartAndEndingMusic.Post(gameObject);
    }
}
