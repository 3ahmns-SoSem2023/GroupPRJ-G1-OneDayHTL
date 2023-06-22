using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT3 : MonoBehaviour
{
    public GameManager3 gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("Du Bist an der Schule angekommen! Gratuliere! Nur Zuspät... Zehentner wär nicht stolz auf dich. Beeil dich!");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Jetzt bist du bei der Klasse, Was machst du?");
        gameManager.texts[4].SetText("Ehrlich sein und grüßen beim Reingehen.");
        gameManager.texts[5].SetText("Reinsneaken wenn der Lehrer wegschaut. Beziehungsweise im richtigen Moment reingehen.");
    }


    public void TextEnding4()
    {
        gameManager.texts[7].SetText("Der Lehrer schaut zwar nicht ganz glücklich aus, aber zumindest freut er sich über deine Ehrlichkeit! ... Du bekommst trotzdem einen Eintrag");
    }

    public void TextEnding5()
    {
        gameManager.texts[7].SetText("Der Lehrer Sieht dich und ist Sehr abgefuckt dass du so hinterhältig bist. Du beckomst ein Stück Kreide ab und wirst als fehlend eingetragen.");
    }
}
