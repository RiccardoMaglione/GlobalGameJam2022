using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonArt : MonoBehaviour
{
    public Image ThisImage;

    public Sprite Hover;
    public Sprite Dehover;

    public GameObject Fire;

    public void ImageHover()
    {
        Fire.SetActive(true);
        ThisImage.sprite = Hover;
    }
    public void ImageDehover()
    {
        Fire.SetActive(false);
        ThisImage.sprite = Dehover;
    }
}
