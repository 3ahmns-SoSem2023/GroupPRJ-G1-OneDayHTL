using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxT5 : MonoBehaviour
{
    public GameManager5 gameManager;
    public void TextStart()
    {
        gameManager.texts[0].SetText("Du bist zu sp‰t und hast absolut kranken Hunger. Schlimmer gehts nicht.");
        gameManager.texts[1].SetText("In School");
        gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
        gameManager.texts[3].SetText("Willst du dir was schnelles zum Naschen holen?");
        gameManager.texts[4].SetText("Ja, kann man schon machen, jetzt is eh schon Wurst. Dann ist mindestens der Hunger weg.");
        gameManager.texts[5].SetText("Nein, ich geh gleich in die Klasse und werde mitmachen.");
    }

   // public void TextSkip1()
  //  {
   //     gameManager.texts[0].SetText("Second Scene");
     //   gameManager.texts[1].SetText("In School");
       // gameManager.texts[2].SetText(gameManager.efctStorage.FetchStatus());
//        gameManager.texts[3].SetText("Choose");
    //    gameManager.texts[4].SetText("Dodge");
    //    gameManager.texts[5].SetText("Ignore");
 //   }


    public void TextEnding8()
    {
        gameManager.texts[7].SetText("Du hast versucht, den Stoff von den ersten 20 Minuten nachzuholen, aber du kannst dich echt nicht Konzentrieren. Basicly bist du den ganzen Tag scheiﬂe drauf, depresiv und am Daydreamen.");
    }

   // public void TextEnding9()
  //  {
   //     gameManager.texts[7].SetText("Ending9");
  //  }

    public void TextEnding10()
    {
        gameManager.texts[7].SetText("Als du in die zweite Sunde gehen wolltest hat dich der Lehrer aus der erste Stunde gesehen und zusammengeschissen.");
    }
}
