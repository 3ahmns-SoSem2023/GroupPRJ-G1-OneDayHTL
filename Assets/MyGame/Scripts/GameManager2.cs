using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 Instance;
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
        SlackOff1,
        WorkHard2,
        Ending2,
        Ending3,
        Ending11
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
                if (efctStorage.statusEffects[0])
                {
                    efctStorage.statusEffects[0] = false;
                    efctStorage.statusEffects[3] = true;
                }
                Invoke("STStart0", 0.01f);
                break;
            case GameState.SlackOff1:
                STSlackOff1();
                break;
            case GameState.WorkHard2:
                STWorkHard2();
                break;
            case GameState.Ending2:
                Ending2();
                break;
            case GameState.Ending3:
                Ending3();
                break;
            case GameState.Ending11:
                Ending11();
                break;
        }
    }

    //Check wann und welcher Knopf gedr�ckt wurde
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
    //ST == Scene Transition, setzt Text, Bild, Ambience & co f�r neue Szenen
    public void STStart0()
    {
        //no status effects

        texts[0].SetText("First Scene");
        texts[1].SetText("In School");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("SlackOff");
        texts[5].SetText("WorkHard");

        images[0].SetImg(sprites[0]);

        nxtState1 = GameState.SlackOff1;
        nxtState2 = GameState.WorkHard2;

        //Wwise
        //playStartAndEndingMusic.Post(gameObject);
        //playWeckerAtmo.Post(gameObject); 
    }

    public void STSlackOff1()
    {
        if (efctStorage.statusEffects[3])
        {
            if (Random.Range(0, 100) > 5)
            {
                UpdateGameState(GameState.Ending2);
            }
            else
            {
                UpdateGameState(GameState.Ending11);
            }
        }
        else
        {
            UpdateGameState(GameState.Ending2);
        }
        //Wwise
        //playWeckerEarly.Post(gameObject);
        //stopStartAndEndingMusic.Post(gameObject); 
    }
    //Update this
    public void STWorkHard2()
    {
        if (efctStorage.statusEffects[3])
        {
            if (Random.Range(0, 100) > 5)
            {
                UpdateGameState(GameState.Ending3);
            }
            else
            {
                UpdateGameState(GameState.Ending11);
            }
        }
        else
        {
            UpdateGameState(GameState.Ending3);
        }
        //Wwise
        //playWeckerLate.Post(gameObject);
        //stopStartAndEndingMusic.Post(gameObject);
    }

    public void Ending2()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending2");
        images[0].SetImg(sprites[2]);


        //Wwise
        //stopWeckerAtmo.Post(gameObject);
        //playStartAndEndingMusic.Post(gameObject);
    }

    public void Ending3()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending3");
        images[0].SetImg(sprites[2]);


        //Wwise
        //stopWeckerAtmo.Post(gameObject);
        //playStartAndEndingMusic.Post(gameObject);
    }

    public void Ending11()
    {
        oneButton.SetActive(false);
        twoButtons.SetActive(false);

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false);
        }

        texts[7].gameObject.SetActive(true);
        texts[7].SetText("Ending11");
        images[0].SetImg(sprites[2]);


        //Wwise
        //stopWeckerAtmo.Post(gameObject);
        //playStartAndEndingMusic.Post(gameObject);
    }
}
