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


    [Header("Time for fade image/text of buttons: Spared/Devoured")]
    [Tooltip("Time del fade da alpha 100 a 0 dell'immagine del bottone spared/graziato e devoured/divorato")]
    public float ButtonTimeFadeAlphaToZero;
    [Tooltip("Time del fade da alpha 0 a 100 del testo bottone spared/graziato e devoured/divorato")]
    public float TextTimeFadeAlphaToMax;



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
        ObjectToFade.GetComponent<Image>().CrossFadeAlpha(1, 0.5f, false);
    }

    public IEnumerator FadeInChangeDialogueIEnum(GameObject ObjectToFade, Color ColorToAlpha)
    {
        yield return new WaitForSeconds(BlackPanelTimeToWait);
        ObjectToFade.GetComponent<Image>().CrossFadeAlpha(0, 1f, false);
    }

    /// <summary>
    /// Metodo che esegue un fade sulle immagini del bottone di "Spared/Graziato" e "Devoured/Divorato" di quando il giocatore deve scegliere
    /// </summary>
    /// <param name="ObjectToFade"></param>
    public void FadeImage(GameObject ObjectToFade)
    {
        ObjectToFade.GetComponent<Image>().CrossFadeAlpha(0, 0, false);
        ObjectToFade.GetComponent<Image>().CrossFadeAlpha(1, 5, false);
    }

    /// <summary>
    /// Metodo che esegue un fade sul testo "Spared/Graziato" e "Devoured/Divorato" dei bottoni di quando il giocatore deve scegliere
    /// </summary>
    /// <param name="TextToFade"></param>
    public void FadeText(Text TextToFade)
    {
        TextToFade.CrossFadeAlpha(0, 0, false);
        TextToFade.CrossFadeAlpha(1, 5, false);
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
