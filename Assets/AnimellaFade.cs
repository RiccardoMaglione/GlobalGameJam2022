using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimellaFade : StateMachineBehaviour
{
    GameObject FadeAnimelle;
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("test", true);

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("AnimellaFade1"))
        {
            Debug.Log("1");
            animator.SetBool("AnimelleParameters", true);
            FadeAnimelle = GameObject.Find("AnimellaFade");
            FadeAnimelle.GetComponent<FadeCharacter>().FunctionFadeDialogue(FadeAnimelle.GetComponent<FadeCharacter>().FadeDialogue1, animator);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("AnimellaFade2"))
        {
            Debug.Log("2");
            animator.SetBool("AnimelleParameters", true);
            FadeAnimelle = GameObject.Find("AnimellaFade");
            FadeAnimelle.GetComponent<FadeCharacter>().FunctionFadeDialogue(FadeAnimelle.GetComponent<FadeCharacter>().FadeDialogue2, animator);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("AnimellaFade3"))
        {
            Debug.Log("3");
            animator.SetBool("AnimelleParameters", true);
            FadeAnimelle = GameObject.Find("AnimellaFade");
            FadeAnimelle.GetComponent<FadeCharacter>().FunctionFadeDialogue(FadeAnimelle.GetComponent<FadeCharacter>().FadeDialogue3, animator);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("AnimellaFade4"))
        {
            Debug.Log("4");
            animator.SetBool("AnimelleParameters", true);
            FadeAnimelle = GameObject.Find("AnimellaFade");
            FadeAnimelle.GetComponent<FadeCharacter>().FunctionFadeDialogue(FadeAnimelle.GetComponent<FadeCharacter>().FadeDialogue4, animator);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("AnimellaFade5"))
        {
            Debug.Log("5");
            animator.SetBool("AnimelleParameters", true);
            FadeAnimelle = GameObject.Find("AnimellaFade");
            FadeAnimelle.GetComponent<FadeCharacter>().FunctionFadeDialogue(FadeAnimelle.GetComponent<FadeCharacter>().FadeDialogue5, animator);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("AnimellaFade6"))
        {
            Debug.Log("6");
            animator.SetBool("AnimelleParameters", true);
            FadeAnimelle = GameObject.Find("AnimellaFade");
            FadeAnimelle.GetComponent<FadeCharacter>().FunctionFadeDialogue(FadeAnimelle.GetComponent<FadeCharacter>().FadeDialogue6, animator);
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
