using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT2 : MonoBehaviour
{
    public GameManager gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("First Scene");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("SlackOff");
        gameManager.texts[5].SetText("WorkHard");
    }


    public void TextEnding2()
    {
        gameManager.texts[7].SetText("Ending2");
    }

    public void TextEnding3()
    {
        gameManager.texts[7].SetText("Ending3");
    }

    public void TextEnding11()
    {
        gameManager.texts[7].SetText("Ending11");
    }

}
