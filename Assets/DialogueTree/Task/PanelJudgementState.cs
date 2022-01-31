using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelJudgementState : StateMachineBehaviour
{
    GameObject judgementManager;
    GameObject CountSoul;
    public bool JudgeSpared;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(AudioManager.instance != null)
        {
            AudioManager.instance.Play("giudicato");
        }
        
        animator.SetBool("FinishJudgement", true);
        
        judgementManager = GameObject.Find("JudgementManager");
        CountSoul = GameObject.Find("CountJudgmenet");

        if (JudgeSpared)
        {
            Debug.Log("Spared");
            judgementManager.GetComponent<JudgementPanel>().DeactivePanelSpared(animator);
            CountSoul.GetComponent<CountJudgementAnimelle>().CountUpSpared();
        }
        else
        {
            Debug.Log("Devoured");
            judgementManager.GetComponent<JudgementPanel>().DeactivePanelDevoured(animator);
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("test", false);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
