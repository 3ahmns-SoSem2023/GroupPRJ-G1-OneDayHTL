using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT4 : MonoBehaviour
{
    public GameManager gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("First Scene");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("Push");
        gameManager.texts[5].SetText("Relax");
    }


    public void TextEnding6()
    {
        gameManager.texts[7].SetText("Ending6");
    }

    public void TextEnding7()
    {
        gameManager.texts[7].SetText("Ending7");
    }
}
