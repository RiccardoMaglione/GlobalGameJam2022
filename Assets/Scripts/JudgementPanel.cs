using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgementPanel : MonoBehaviour
{
    #region Variables
    [Tooltip("Variabile che contiene il pannello che indica che l'anima è assolta")]
    public GameObject PanelJudgeSpared;                         //Variabile che contiene il pannello che indica che l'anima è assolta
    [Tooltip("Variabile che contiene il pannello che indica che l'anima è colpevole")] 
    public GameObject PanelJudgeDevoured;                       //Variabile che contiene il pannello che indica che l'anima è colpevole

    [Tooltip("Variabile che indica tra quanto tempo dopo l'attivazione il pannello dell'assoluzione si disattiva")] 
    public float TimeDeactivatePanelSpared;                     //Variabile che indica tra quanto tempo dopo l'attivazione il pannello dell'assoluzione si disattiva
    [Tooltip("Variabile che indica tra quanto tempo dopo l'attivazione il pannello della condanna si disattiva")]
    public float TimeDeactivatePanelDevoured;                    //Variabile che indica tra quanto tempo dopo l'attivazione il pannello della condanna si disattiva
    #endregion

    #region Method and Function
    /// <summary>
    /// Metodo per disattivare il pannello dell'assoluzione tramite una coroutine
    /// </summary>
    /// <param name="anim"></param>
    public void DeactivePanelSpared(Animator anim)
    {
        StartCoroutine(PanelSparedDeactive(anim));
    }

    /// <summary>
    /// Metodo per disattivare il pannello della condanna tramite una coroutine
    /// </summary>
    /// <param name="anim"></param>
    public void DeactivePanelDevoured(Animator anim)
    {
        StartCoroutine(PanelDevouredDeactive(anim));
    }
    #endregion
    
    #region Coroutine
    /// <summary>
    /// Coroutine per disattivare il pannello della condanna dopo tot secondi
    /// </summary>
    /// <param name="anim"></param>
    /// <returns></returns>
    public IEnumerator PanelSparedDeactive(Animator anim)
    {
        PanelJudgeSpared.SetActive(true);
        yield return new WaitForSeconds(TimeDeactivatePanelSpared);
        PanelJudgeSpared.SetActive(false);
        anim.SetBool("FinishJudgement", false);
    }

    /// <summary>
    /// Coroutine per disattivare il pannello della condanna dopo tot secondi
    /// </summary>
    /// <param name="anim"></param>
    /// <returns></returns>
    public IEnumerator PanelDevouredDeactive(Animator anim)
    {
        PanelJudgeDevoured.SetActive(true);
        yield return new WaitForSeconds(TimeDeactivatePanelDevoured);
        PanelJudgeDevoured.SetActive(false);
        anim.SetBool("FinishJudgement", false);
    }
    #endregion
}