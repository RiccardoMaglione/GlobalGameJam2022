using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgementPanel : MonoBehaviour
{
    public GameObject PanelJudgeLetItOut;
    public GameObject PanelJudgeCondamn;

    public IEnumerator PanelLetItOutDeactive(Animator anim)
    {
        PanelJudgeLetItOut.SetActive(true);
        yield return new WaitForSeconds(3);
        PanelJudgeLetItOut.SetActive(false);
        anim.SetBool("FinishJudgement", false);
    }

    public IEnumerator PanelCondemnDeactive(Animator anim)
    {
        PanelJudgeCondamn.SetActive(true);
        yield return new WaitForSeconds(3);
        PanelJudgeCondamn.SetActive(false);
        anim.SetBool("FinishJudgement", false);
    }

    public void DeactivePanelLetItOut(Animator anim)
    {
        StartCoroutine(PanelLetItOutDeactive(anim));
    }
    public void DeactivePanelCondamn(Animator anim)
    {
        StartCoroutine(PanelCondemnDeactive(anim));
    }
}