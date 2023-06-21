using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT1 : MonoBehaviour
{
    public GameManager gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("First Scene");
        gameManager.texts[1].SetText("In Bed");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("early");
        gameManager.texts[5].SetText("late");
    }

    public void TextEarly1()
    {
        gameManager.texts[0].SetText("SecondScene");
        gameManager.texts[1].SetText("Home");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("quick");
        gameManager.texts[5].SetText("slow");
    }

    public void TextLate2()
    {
        gameManager.texts[0].SetText("ThirdScene");
        gameManager.texts[1].SetText("Home");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[6].SetText("quick");
    }
    public void TextEnding1()
    {
        gameManager.texts[7].SetText("Ending1");
    }
}
