using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State, nxtState1, nxtState2;
    public ChangeTxT[] texts;
    public Sprite[] sprites;
    public ChangeImg[] images;
    public StatusEffectStorage efctStorage;
    public GameObject twoButtons, oneButton;

    [Header("Wwise Variablen")]
    public AK.Wwise.Event playWeckerAtmo;
    public AK.Wwise.Event stopWeckerAtmo;

    public AK.Wwise.Event playStartAndEndingMusic;
    public AK.Wwise.Event stopStartAndEndingMusic;

    public AK.Wwise.Event playWeckerEarly;
    public AK.Wwise.Event playWeckerLate;

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
        PrepSlow,
        QuickPrep,
        Chapter1,
        Chapter2,
        Chapter3,
        Chapter4,
        Ending1
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
                efctStorage.statusEffects[0] = true;
                STEarly1();
                break;
            case GameState.Late2:
                if (Random.Range(0, 2) == 0)
                {
                    STEarly1();
                }
                else
                {
                    STLate2();
                }
                break;
            case GameState.PrepSlow:
                PrepSlow();
                break;
            case GameState.Chapter1:
                Chapter1();
                break;
            case GameState.Chapter2:
                Chapter2();
                break;
            case GameState.Chapter3:
                Chapter3();
                break;
            case GameState.Chapter4:
                Chapter4();
                break;
            case GameState.QuickPrep:
                QuickPrep();
                break;
            case GameState.Ending1:
                Ending1();
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
        texts[1].SetText("In Bed");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("early");
        texts[5].SetText("late");

        images[0].SetImg(sprites[0]);

        nxtState1 = GameState.Early1;
        nxtState2 = GameState.Late2;

        //Wwise
        playStartAndEndingMusic.Post(gameObject);
        playWeckerAtmo.Post(gameObject); 
    }

    public void STEarly1()
    {
        //effects are done earlier

        texts[0].SetText("Second Scene");
        texts[1].SetText("Home");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[4].SetText("quick");
        texts[5].SetText("slow");

        images[0].SetImg(sprites[1]);

        nxtState1 = GameState.QuickPrep;
        nxtState2 = GameState.PrepSlow;

        //Wwise
        playWeckerEarly.Post(gameObject);
        stopStartAndEndingMusic.Post(gameObject); 
    }
    //Update this
    public void STLate2()
    {
        efctStorage.statusEffects[2] = true;

        OneButton();

        texts[0].SetText("Third Scene");
        texts[1].SetText("Home");
        texts[2].SetText(efctStorage.FetchStatus());
        texts[3].SetText("Choose");
        texts[6].SetText("quick");

        images[0].SetImg(sprites[1]);

        nxtState1 = GameState.QuickPrep;

        //Wwise
        playWeckerLate.Post(gameObject);
        stopStartAndEndingMusic.Post(gameObject);
    }

    public void PrepSlow()
    {
        if (Random.Range(0, 100) > 15)
        {
            UpdateGameState(GameState.Chapter1);
        }
        else
        {
            UpdateGameState(GameState.Chapter2);
        }
        
    }

    public void QuickPrep()
    {
        efctStorage.statusEffects[1] = true;
        if (efctStorage.statusEffects[2])
        {
            UpdateGameState(GameState.Chapter4);
        }
        else
        {
            UpdateGameState(GameState.Chapter3);
        }

    }

    public void Chapter1()
    {
        //Checks for tired and first ending
        if (efctStorage.statusEffects[0])
        {
            if (Random.Range(0, 100) > 5)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                UpdateGameState(GameState.Ending1);
            }
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Chapter2()
    {
        //Checks for tired and first ending
        if (efctStorage.statusEffects[0])
        {
            if (Random.Range(0, 100) > 5)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                UpdateGameState(GameState.Ending1);
            }
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Chapter3()
    {
        //Checks for tired and first ending
        if (efctStorage.statusEffects[0])
        {
            if (Random.Range(0, 100) > 5)
            {
                SceneManager.LoadScene(3);
            }
            else
            {
                UpdateGameState(GameState.Ending1);
            }
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }

    public void Chapter4()
    {
        //Checks for tired and first ending
        if (efctStorage.statusEffects[0])
        {
            if (Random.Range(0, 100) > 5)
            {
                SceneManager.LoadScene(4);
            }
            else
            {
                UpdateGameState(GameState.Ending1);
            }
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }

    public void Ending1()
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


        //Wwise
        stopWeckerAtmo.Post(gameObject);
        playStartAndEndingMusic.Post(gameObject);
    }
}
