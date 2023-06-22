using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT2 : MonoBehaviour
{
    public GameManager2 gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("Du Bist an der Schule angekommen! Gratuliere!");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Was als nächstes?");
        gameManager.texts[4].SetText("Erstmal bisschen Chillen. Kollegas sind in der Kafetaria.");
        gameManager.texts[5].SetText("Okay. Ich geh gleich in die Klasse und gib alles heute.");
    }


    public void TextEnding2()
    {
        gameManager.texts[7].SetText("Du hast den Überraschungstest komplett verpasst, weil du die Zeit vergessen hast, während du mit deine Kollegas in der Cafeteria gegessen hast.");
    }

    public void TextEnding3()
    {
        gameManager.texts[7].SetText("Du hast den ganzen Tag hart gearbeitet und den Überraschungstest mit Leichtigkeit bestanden.");
    }

    
    // für das ending 11 fehlt die "tired" bzw "energy?" zwischenabfrage für einen Energ

    public void TextEnding11()
    {
        gameManager.texts[7].SetText("du bist ohne grund mit 5%iger wahrscheinlichkeit gestorben lol. HTL eben");
    }

}
