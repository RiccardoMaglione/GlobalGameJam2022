using UnityEngine;
using UnityEngine.UI;

public class NextCharacter : StateMachineBehaviour
{
    CharactersManager characterManager;
    ButtonManager buttonManager;
    //GameObject fiot;
    //float timer; //rif a fadeobject panel
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //fiot = GameObject.Find("FadeManager");
        //fiot.GetComponent<FadeObject>().PanelBlack.SetActive(true);
        //fiot.GetComponent<FadeObject>().FadeChangeDialogue(fiot.GetComponent<FadeObject>().PanelBlack);

        //characterManager = FindObjectOfType<CharactersManager>();
        //buttonManager = FindObjectOfType<ButtonManager>();
        //buttonManager.i++;
        //characterManager.PlayDialogue();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //timer += Time.deltaTime;
        //if(timer >= 1)
        //{
        //    fiot.GetComponent<FadeObject>().CanChangeDialogue = true;
        //}
        //if(fiot.GetComponent<FadeObject>().CanChangeDialogue == true)
        //{
        //    fiot.GetComponent<FadeObject>().CanChangeDialogue = false;
        //    characterManager = FindObjectOfType<CharactersManager>();
        //    buttonManager = FindObjectOfType<ButtonManager>();
        //    buttonManager.i++;
        //    characterManager.PlayDialogue();
        //}

        characterManager = FindObjectOfType<CharactersManager>();
        buttonManager = FindObjectOfType<ButtonManager>();
        buttonManager.i++;
        characterManager.PlayDialogue();
    }
}
