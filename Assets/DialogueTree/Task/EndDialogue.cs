using UnityEngine;

public class EndDialogue : StateMachineBehaviour
{
    CharactersManager characterManager;
    ButtonManager buttonManager;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        characterManager = FindObjectOfType<CharactersManager>();
        buttonManager = FindObjectOfType<ButtonManager>();
        buttonManager.i++;
        characterManager.PlayDialogue();
        animator.SetBool("EndDialogue", true);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("EndDialogue", false);
    }
}
