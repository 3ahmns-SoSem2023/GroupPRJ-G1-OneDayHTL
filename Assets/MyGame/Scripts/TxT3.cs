using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT3 : MonoBehaviour
{
    public GameManager3 gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("Du Bist an der Schule angekommen! Gratuliere! Nur Zusp�t... Zehentner w�r nicht stolz auf dich. Beeil dich!");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Jetzt bist du bei der Klasse, Was machst du?");
        gameManager.texts[4].SetText("Ehrlich sein und gr��en beim Reingehen.");
        gameManager.texts[5].SetText("Reinsneaken wenn der Lehrer wegschaut. Beziehungsweise im richtigen Moment reingehen.");
    }


    public void TextEnding4()
    {
        gameManager.texts[7].SetText("Der Lehrer schaut zwar nicht ganz gl�cklich aus, aber zumindest freut er sich �ber deine Ehrlichkeit! ... Du bekommst trotzdem einen Eintrag");
    }

    public void TextEnding5()
    {
        gameManager.texts[7].SetText("Der Lehrer Sieht dich und ist Sehr abgefuckt dass du so hinterh�ltig bist. Du beckomst ein St�ck Kreide ab und wirst als fehlend eingetragen.");
    }
}
