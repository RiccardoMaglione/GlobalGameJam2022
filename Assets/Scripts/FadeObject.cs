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
    bool CanChangeDialogue;
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
        ColorToAlpha = ObjectToFade.GetComponent<Image>().color;
        ColorToAlpha.a = 0;
        ObjectToFade.GetComponent<Image>().color = ColorToAlpha;

        yield return new WaitForSeconds(BlackPanelTimeToWait);

        while (true)
        {
            if (ObjectToFade.GetComponent<Image>().color.a <= 100)
            {
                ColorToAlpha.a += BlackPanelValueToAddAlpha;
                ObjectToFade.GetComponent<Image>().color = ColorToAlpha;
                yield return new WaitForSeconds(BlackPanelTimerForEveryAddAlpha);
            }
            else if(ObjectToFade.GetComponent<Image>().color.a == 100 && CanChangeDialogue == false)
            {
                CanChangeDialogue = true;
                characterManager = FindObjectOfType<CharactersManager>();
                buttonManager = FindObjectOfType<ButtonManager>();
                buttonManager.i++;
                characterManager.PlayDialogue();
                //Far ritornare canchangedialogue false nel dialogue successivo
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

    public void FadeChangeDialogue(GameObject ObjectToFade)
    {
        StartCoroutine(FadeChangeDialogueIEnum(ObjectToFade, ObjectToFade.GetComponent<Image>().color));
    }
}
