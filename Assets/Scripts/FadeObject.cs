using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeObject : MonoBehaviour
{
    public float TimeToWait;
    public float ValueToAddAlpha;
    public float TimerForEveryAddAlpha;

    public IEnumerator FadeImageIEnum(GameObject ObjectToFade, Color ColorToAlpha)
    {
        ColorToAlpha = ObjectToFade.GetComponent<Image>().color;
        ColorToAlpha.a = 0;
        ObjectToFade.GetComponent<Image>().color = ColorToAlpha;

        yield return new WaitForSeconds(TimeToWait);

        while (true)
        {
            if (ObjectToFade.GetComponent<Image>().color.a <= 100)
            {
                ColorToAlpha.a += ValueToAddAlpha;
                ObjectToFade.GetComponent<Image>().color = ColorToAlpha;
                yield return new WaitForSeconds(TimerForEveryAddAlpha);
            }
        }
    }
    public IEnumerator FadeTextIEnum(Text ObjectToFade, Color ColorToAlpha)
    {
        ColorToAlpha = ObjectToFade.color;
        ColorToAlpha.a = 0;
        ObjectToFade.color = ColorToAlpha;

        yield return new WaitForSeconds(TimeToWait);

        while (true)
        {
            if (ObjectToFade.color.a <= 100)
            {
                ColorToAlpha.a += ValueToAddAlpha;
                ObjectToFade.color = ColorToAlpha;
                yield return new WaitForSeconds(TimerForEveryAddAlpha);
            }
        }
    }

    public void FadeImage(GameObject ObjectToFade)
    {
        StartCoroutine(FadeImageIEnum(ObjectToFade, ObjectToFade.GetComponent<Image>().color));
    }

    public void FadeText(Text TextToFade)
    {
        StartCoroutine(FadeTextIEnum(TextToFade, TextToFade.color));
    }
}
