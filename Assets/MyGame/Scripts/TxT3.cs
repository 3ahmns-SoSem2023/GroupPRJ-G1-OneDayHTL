using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT3 : MonoBehaviour
{
    public GameManager gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("First Scene");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("Apologize");
        gameManager.texts[5].SetText("SneakIn");
    }


    public void TextEnding4()
    {
        gameManager.texts[7].SetText("Ending4");
    }

    public void TextEnding5()
    {
        gameManager.texts[7].SetText("Ending5");
    }
}
