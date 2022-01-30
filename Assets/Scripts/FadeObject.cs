using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeObject : MonoBehaviour
{
    public float TimeToWait;
    public float ValueToAddAlpha;
    public float TimerForEveryAddAlpha;
    [Space(50)]
    public float BlackPanelTimeToWait;
    public float BlackPanelValueToAddAlpha;
    public float BlackPanelTimerForEveryAddAlpha;
    public GameObject PanelBlack;
    [HideInInspector] public bool CanChangeDialogue;
    CharactersManager characterManager;
    ButtonManager buttonManager;
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
    public IEnumerator FadeChangeDialogueIEnum(GameObject ObjectToFade, Color ColorToAlpha)
    {
        CanChangeDialogue = false;
        ObjectToFade.GetComponent<Image>().CrossFadeAlpha(0, 0f, false);
        yield return new WaitForSeconds(BlackPanelTimeToWait);
        ObjectToFade.GetComponent<Image>().CrossFadeAlpha(1, 1f, false);
    }

    public IEnumerator FadeInChangeDialogueIEnum(GameObject ObjectToFade, Color ColorToAlpha)
    {
        yield return new WaitForSeconds(BlackPanelTimeToWait);
        ObjectToFade.GetComponent<Image>().CrossFadeAlpha(0, 1f, false);
    }

    public void FadeImage(GameObject ObjectToFade)
    {
        StartCoroutine(FadeImageIEnum(ObjectToFade, ObjectToFade.GetComponent<Image>().color));
    }

    public void FadeText(Text TextToFade)
    {
        StartCoroutine(FadeTextIEnum(TextToFade, TextToFade.color));
    }

    public void FadeChangeDialogue(GameObject ObjectToFade)
    {
        //ObjectToFade.GetComponent<Image>().CrossFadeAlpha(100, 5, false);
        StartCoroutine(FadeChangeDialogueIEnum(ObjectToFade, ObjectToFade.GetComponent<Image>().color));
    }
    public void FadeInEnterDialogue(GameObject ObjectToFade)
    {
        StartCoroutine(FadeInChangeDialogueIEnum(ObjectToFade, ObjectToFade.GetComponent<Image>().color));
    }
}
