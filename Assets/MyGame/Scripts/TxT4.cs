using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT4 : MonoBehaviour
{
    public GameManager4 gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("Du bist in der Schule angekommen, ... Hast aber meeegaaa Hunger! *knurr*");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Choose");
        gameManager.texts[4].SetText("Okay Common! Das zieh ich jetzt durch! Ich ess daheim etwas.");
        gameManager.texts[5].SetText("Okay: jetzt noch 1 1/2 h duchhalten, dann in der Big Break beim Buffet Pommes und Energy holen.");
    }


    public void TextEnding6()
    {
        gameManager.texts[7].SetText("Du hast dich zu hart gepusht, hast aber dadurch jetzt Kopf- und Bauchweh bekommen. Died as a soldier! R.I.P.");
    }

    public void TextEnding7()
    {
        gameManager.texts[7].SetText("Okay: jetzt noch 1 1/2 h duchhalten, dann in der Big Break beim Buffet Pommes und Energy holen.");
    }
}
