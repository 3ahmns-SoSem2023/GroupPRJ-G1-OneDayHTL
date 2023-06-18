using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager3 : MonoBehaviour
{
    public static GameManager3 Instance;
    public GameState State, nxtState1, nxtState2;
    public ChangeTxT[] texts;
    public Sprite[] sprites;
    public ChangeImg[] images;
    public StatusEffectStorage efctStorage;
    public GameObject twoButtons, oneButton, storageObj;

    /*[Header("Wwise Variablen")]
    public AK.Wwise.Event playWeckerAtmo;
    public AK.Wwise.Event stopWeckerAtmo;

    public AK.Wwise.Event playStartAndEndingMusic;
    public AK.Wwise.Event stopStartAndEndingMusic;

    public AK.Wwise.Event playWeckerEarly;
    public AK.Wwise.Event playWeckerLate;*/

    private void Awake()
    {
        Instance = this;
    }

    //Liste aller GameStates
    public enum GameState
    {
        StartScreen0,
        Apologize1,
        SneakIn2,
        Ending4,
        Ending5
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
            case GameState.Apologize1:
                STApologize1();
                break;
            case GameState.SneakIn2:
                STSneakIn2();
                break;
            case GameState.Ending4:
                Ending4();
                break;
            case GameState.Ending5:
                Ending5();
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
        texts[4].SetText("Apologize");
        texts[5].SetText("SneakIn");

        images[0].SetImg(sprites[0]);

        nxtState1 = GameState.Apologize1;
        nxtState2 = GameState.SneakIn2;

        //Wwise
        //playStartAndEndingMusic.Post(gameObject);
        //playWeckerAtmo.Post(gameObject); 
    }

    public void STApologize1()
    {
        UpdateGameState(GameState.Ending4);
        //Wwise
        //playWeckerEarly.Post(gameObject);
        //stopStartAndEndingMusic.Post(gameObject); 
    }
    //Update this
    public void STSneakIn2()
    {
        UpdateGameState(GameState.Ending5);
        //Wwise
        //playWeckerLate.Post(gameObject);
        //stopStartAndEndingMusic.Post(gameObject);
    }

    public void Ending4()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending4");
        images[0].SetImg(sprites[2]);


        //Wwise
        //stopWeckerAtmo.Post(gameObject);
        //playStartAndEndingMusic.Post(gameObject);
    }

    public void Ending5()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending5");
        images[0].SetImg(sprites[2]);


        //Wwise
        //stopWeckerAtmo.Post(gameObject);
        //playStartAndEndingMusic.Post(gameObject);
    }
}
