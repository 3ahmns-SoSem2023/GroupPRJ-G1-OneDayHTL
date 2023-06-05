using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImg : MonoBehaviour
{
    private Image img;

    private void Start()
    {
        img = gameObject.GetComponent<Image>();
    }

    public void SetImg(Sprite newImg)
    {
        img.sprite = newImg;
    }
}
