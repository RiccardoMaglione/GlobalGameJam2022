using UnityEngine;

public class NextCharacter : StateMachineBehaviour
{
    CharactersManager characterManager;
    ButtonManager buttonManager;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        characterManager = FindObjectOfType<CharactersManager>();
        buttonManager = FindObjectOfType<ButtonManager>();
        buttonManager.i++;
        characterManager.PlayDialogue();
    }
}
