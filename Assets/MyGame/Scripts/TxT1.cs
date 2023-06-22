using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT1 : MonoBehaviour
{
    public GameManager gameManager;
    public void TextStart()
    {
        //What is happening
        gameManager.texts[0].SetText("Servus und Willkommen zu einem Text Adventure �ber den klassischen Tag eines Sch�lers an der HTL Itzling. Du bist ein Sch�ler/eine Sch�lerin in der dritten Klasse und bereitest dich in ein aufregendes Abenteuer am n�chsten Tag vor. Bist du bereit, deine Schultasche zu schnappen und loszulegen?");
        //where are you
        gameManager.texts[1].SetText("In Bed");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        //what do you need to do
        gameManager.texts[3].SetText("Pack mal deinen Ranzen und stell dir den Wecker! Bis Morgen!");
        //choice 1
        gameManager.texts[4].SetText("Wecker fr�her stellen");
        //choice 2
        gameManager.texts[5].SetText("Wecker sp�ter stellen");
    }

    public void TextEarly1()
    {
        gameManager.texts[0].SetText("Du bist rechtzeitig aufgestanden!");
        gameManager.texts[1].SetText("Home");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText(" Was willst du jetzt machen?");
        gameManager.texts[4].SetText("Ich beeil mich mal lieber, Ich habe heute noch einen Test wof�r ich noch im Bus lernen muss.");
        gameManager.texts[5].SetText("Erstmal was geiles Fr�hst�cken digga. Wo hat meine Mudda denn die Lasagne von gestern hingetan???");
    }

    public void TextLate2()
    {
        gameManager.texts[0].SetText("Du hast den Wecker nicht geh�rt...");
        gameManager.texts[1].SetText("Home");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("...");
        gameManager.texts[6].SetText("Oh Shit man, Ich hab �belst verschlafen! Ich sollte mich jetzt wirklich beeilen, sont verpasse ich noch den Bus!");
    }
    public void TextEnding1()
    {
        gameManager.texts[7].SetText("Du Bist im Bus eingeschlafen und bis zur letzten Station gefahren. Der Tag ist gelaufen!");
    }
}
