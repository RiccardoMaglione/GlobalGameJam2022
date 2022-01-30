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
        //ThisImage.gameObject.transform.localScale = new Vector3 (1.2f, 1.2f, 1);
        //ThisImage.gameObject.transform.position = new Vector3(ThisImage.gameObject.transform.position.x -1, ThisImage.gameObject.transform.position.y, ThisImage.gameObject.transform.position.z);

    }
    public void ImageDehover()
    {
        Fire.SetActive(false);
        ThisImage.sprite = Dehover;
        //ThisImage.gameObject.transform.localScale = new Vector3 (1, 1, 1);
        //ThisImage.gameObject.transform.position = new Vector3(ThisImage.gameObject.transform.position.x +1, ThisImage.gameObject.transform.position.y, ThisImage.gameObject.transform.position.z);
    }
}
