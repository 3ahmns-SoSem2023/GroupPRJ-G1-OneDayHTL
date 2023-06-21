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
    public TxT5 textScript;

    [Header("Wwise Variablen")]
    public AK.Wwise.Event playWeckerAtmo;
    public AK.Wwise.Event stopWeckerAtmo;
    public AK.Wwise.Event playSchoolPupilsAtmo;

    public AK.Wwise.Event playStartAndEndingMusic;
    public AK.Wwise.Event stopStartAndEndingMusic;

    public AK.Wwise.Event playWeckerEarly;
    public AK.Wwise.Event playWeckerLate;
    public AK.Wwise.Event stopWeckerLate;

    public AK.Wwise.Event playInteractivMusic;
    public AK.Wwise.Event stopInteractivMusic;

    public AK.Wwise.Event playButtonClick;

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

        textScript.TextStart();

        images[0].SetImg(sprites[0]);

        nxtState1 = GameState.Skip1;
        nxtState2 = GameState.Stay2;

        //Wwise
        AkSoundEngine.SetState("ArrangementStates", "Frame04");
        
    }

    public void STSkip1()
    {
        textScript.TextSkip1();

        images[0].SetImg(sprites[1]);

        nxtState1 = GameState.Dodge3;
        nxtState2 = GameState.Ignore4;
        //Wwise
        AkSoundEngine.SetState("ArrangementStates", "Frame05");
        stopWeckerAtmo.Post(gameObject);
        playSchoolPupilsAtmo.Post(gameObject);
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
        textScript.TextEnding8();
        images[0].SetImg(sprites[1]);


        //Wwise
        playStartAndEndingMusic.Post(gameObject);
        stopInteractivMusic.Post(gameObject);
        AkSoundEngine.SetState("ArrangementStates", "None");
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
        textScript.TextEnding9();
        images[0].SetImg(sprites[1]);


        //Wwise
        playStartAndEndingMusic.Post(gameObject);
        stopInteractivMusic.Post(gameObject);
        AkSoundEngine.SetState("ArrangementStates", "None");
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
        textScript.TextEnding10();
        images[0].SetImg(sprites[1]);


        //Wwise
        playStartAndEndingMusic.Post(gameObject);
        stopInteractivMusic.Post(gameObject);
        AkSoundEngine.SetState("ArrangementStates", "None");
    }
}
