using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT1 : MonoBehaviour
{
    public GameManager gameManager;
    public void TextStart()
    {
        //What is happening
        gameManager.texts[0].SetText("Servus und Willkommen zu einem Text Adventure über den klassischen Tag eines Schülers an der HTL Itzling. Du bist ein Schüler/eine Schülerin in der dritten Klasse und bereitest dich in ein aufregendes Abenteuer am nächsten Tag vor. Bist du bereit, deine Schultasche zu schnappen und loszulegen?");
        //where are you
        gameManager.texts[1].SetText("In Bed");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        //what do you need to do
        gameManager.texts[3].SetText("Pack mal deinen Ranzen und stell dir den Wecker! Bis Morgen!");
        //choice 1
        gameManager.texts[4].SetText("Wecker früher stellen");
        //choice 2
        gameManager.texts[5].SetText("Wecker später stellen");
    }

    public void TextEarly1()
    {
        gameManager.texts[0].SetText("Du bist rechtzeitig aufgestanden!");
        gameManager.texts[1].SetText("Home");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText(" Was willst du jetzt machen?");
        gameManager.texts[4].SetText("Ich beeil mich mal lieber, Ich habe heute noch einen Test wofür ich noch im Bus lernen muss.");
        gameManager.texts[5].SetText("Erstmal was geiles Frühstücken digga. Wo hat meine Mudda denn die Lasagne von gestern hingetan???");
    }

    public void TextLate2()
    {
        gameManager.texts[0].SetText("Du hast den Wecker nicht gehört...");
        gameManager.texts[1].SetText("Home");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("...");
        gameManager.texts[6].SetText("Oh Shit man, Ich hab übelst verschlafen! Ich sollte mich jetzt wirklich beeilen, sont verpasse ich noch den Bus!");
    }
    public void TextEnding1()
    {
        gameManager.texts[7].SetText("Du Bist im Bus eingeschlafen und bis zur letzten Station gefahren. Der Tag ist gelaufen!");
    }
}
