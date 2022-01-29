using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgementPanel : MonoBehaviour
{
    public GameObject PanelJudgeLetItOut;
    public GameObject PanelJudgeCondamn;

    public IEnumerator PanelLetItOutDeactive()
    {
        PanelJudgeLetItOut.SetActive(true);
        yield return new WaitForSeconds(3);
        PanelJudgeLetItOut.SetActive(false);
    }

    public IEnumerator PanelCondamnDeactive()
    {
        PanelJudgeCondamn.SetActive(true);
        yield return new WaitForSeconds(3);
        PanelJudgeCondamn.SetActive(false);
    }

    public void DeactivePanelLetItOut()
    {
        StartCoroutine(PanelLetItOutDeactive());
    }
    public void DeactivePanelCondamn()
    {
        StartCoroutine(PanelCondamnDeactive());
    }
}