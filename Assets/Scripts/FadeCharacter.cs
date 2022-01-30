using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeCharacter : MonoBehaviour
{
    public Image[] FadeDialogue1;
    public Image[] FadeDialogue2;
    public Image[] FadeDialogue3;
    public Image[] FadeDialogue4;
    public Image[] FadeDialogue5;
    public Image[] FadeDialogue6;

    public float TimeBetweenAnimellaAndDialogue = 1f;

    public void FunctionFadeDialogue(Image[] FadeDialogueTemp, Animator anim)
    {
        DeactiveAnimelle();
        StartCoroutine(FadedDialogueFuncIEnum(FadeDialogueTemp, anim));
    }

    public IEnumerator FadedDialogueFuncIEnum(Image[] FadeDialogueTemp, Animator anim)
    {
        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < FadeDialogueTemp.Length; i++)
        {
            FadeDialogueTemp[i].gameObject.SetActive(true);
            FadeDialogueTemp[i].CrossFadeAlpha(0, 0, false);
        }

        for (int i = 0; i < FadeDialogueTemp.Length; i++)
        {
            FadeDialogueTemp[i].CrossFadeAlpha(1, 0.5f, false);
            StartCoroutine(IEnumFuctionFadeDialogue(anim));
        }
    }

    public IEnumerator IEnumFuctionFadeDialogue(Animator anim)
    {
        yield return new WaitForSeconds(TimeBetweenAnimellaAndDialogue);
        anim.SetBool("AnimelleParameters", false);
    }

    public void DeactiveAnimelle()
    {
        for (int i = 0; i < FadeDialogue1.Length; i++)
        {
            FadeDialogue1[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < FadeDialogue2.Length; i++)
        {
            FadeDialogue3[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < FadeDialogue3.Length; i++)
        {
            FadeDialogue3[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < FadeDialogue4.Length; i++)
        {
            FadeDialogue4[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < FadeDialogue5.Length; i++)
        {
            FadeDialogue5[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < FadeDialogue6.Length; i++)
        {
            FadeDialogue6[i].gameObject.SetActive(false);
        }
    }
}
