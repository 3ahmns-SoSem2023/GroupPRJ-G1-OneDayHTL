using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT5 : MonoBehaviour
{
    public GameManager gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("First Scene");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("Skip");
        gameManager.texts[5].SetText("Stay");
    }

    public void TextSkip1()
    {
        gameManager.texts[0].SetText("Second Scene");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("Dodge");
        gameManager.texts[5].SetText("Ignore");
    }


    public void TextEnding8()
    {
        gameManager.texts[7].SetText("Ending8");
    }

    public void TextEnding9()
    {
        gameManager.texts[7].SetText("Ending9");
    }

    public void TextEnding10()
    {
        gameManager.texts[7].SetText("Ending10");
    }
}
