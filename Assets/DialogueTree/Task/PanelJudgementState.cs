using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelJudgementState : StateMachineBehaviour
{
    GameObject judgementManager;
    public bool JudgeLetItOut;
    public float timer;
    GameObject CountSoul;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("FinishJudgement", true);
        judgementManager = GameObject.Find("JudgementManager");
        CountSoul = GameObject.Find("CountJudgmenet");
        if (JudgeLetItOut)
        {
            judgementManager.GetComponent<JudgementPanel>().DeactivePanelLetItOut(animator);
            CountSoul.GetComponent<CountJudgementAnimelle>().CountUpSpare();
        }
        else
        {
            judgementManager.GetComponent<JudgementPanel>().DeactivePanelCondamn(animator);
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
