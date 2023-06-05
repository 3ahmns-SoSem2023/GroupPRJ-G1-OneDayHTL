using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTxT : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt;

    private void Start()
    {
        //Findet den Text auf dem Objekt und speichert ihn in die Variable
        txt = gameObject.GetComponent<TextMeshProUGUI>();
    }

    //Setzt den Text des Objektes auf den neuen Text
    public void SetText(string newTxT)
    {
        txt.text = newTxT;
    }
}
